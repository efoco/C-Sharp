using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace ModuleRegistration_1
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int moduleCounter = 0;
        Module[] arrayOfModules=new Module[16];
        Module[] arrayOfChosenModules = new Module[8];
        Timetable Sched = new Timetable();

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readXML();            
            Sched.createTimetable(schedule1,schedule2);
        }

        private void listOfModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index= listOfModules.SelectedIndex;
            labelCode.Text = "Code: "+arrayOfModules[index].module_code;
            labelCapacity.Text = "Capacity: " + arrayOfModules[index].module_capacity;
            labelModname.Text = "Name: " + arrayOfModules[index].module_name;
            labelPrerequisites.Text = "Prerequisite: " + arrayOfModules[index].module_prerequisites;
            labelSemester.Text = "Semester: " + arrayOfModules[index].module_semester;
            labelLecture.Text = "Lecture Slot: " + arrayOfModules[index].module_lectures;
            labelTutorial.Text = "Tutorial Slot: " + arrayOfModules[index].module_tutorials;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int index = listOfModules.SelectedIndex;
            if (index >= 0)    //CHECK IF AN ITEM IS SELECTED IN THE CHOSEN MODULES BOX 
            {
                
                if (moduleCounter >= 8) { MessageBox.Show("Error:\r\nYou have reached the module limit"); }
                if ((addModule(index) == true) && (moduleCounter < 8))
                {
                    int x = int.Parse(arrayOfModules[index].module_capacity);//KEEPING TRACK OF MODULE CAPACITY
                    x--;
                    arrayOfModules[index].module_capacity = x.ToString();
                    arrayOfChosenModules[moduleCounter] = arrayOfModules[index];
                    listOfChosenModules.Items.Add(arrayOfChosenModules[moduleCounter].module_name);
                    
                    Sched.addToSlot(arrayOfChosenModules[moduleCounter]);
                    if(comboBox1.SelectedItem.ToString()=="1"){  //IMPORTING THE SCHED1 OR SCHED2
                        schedule1 = Sched.sch1;
                    }
                    else if(comboBox1.SelectedItem.ToString()=="2"){
                    schedule1=Sched.sch2;
                    }
                    moduleCounter++;
                                      
                }

             }
        }
        private bool addModule(int index)
        {
            bool result = true;
            bool isPrerequisite = true;
            if (arrayOfModules[index].module_prerequisites != "none") { /*IF THE MODULE HAS PREREQUISITES THEN SET BOOL TO FALSE.
                                                                          THEN IF THE PREREQUISITE HAS BEEN SELECTED SET BOOL TO TRUE
                                                                         **/
                isPrerequisite = false;        
               
                for (int i = 0; i < arrayOfChosenModules.Length; i++) { 
                    if (arrayOfChosenModules[i] != null) {
                       if (arrayOfModules[index].module_prerequisites == arrayOfChosenModules[i].module_code) {
                           isPrerequisite=true; 
                           break; }
                    }
                   }
                
            }
            if (isPrerequisite == true) 
            {
                for (int i = 0; i < arrayOfChosenModules.Length; i++)  //CHECKING NAME AND TIME CLASHES
                {
                    if (arrayOfChosenModules[i] != null)
                    {
                        if (arrayOfChosenModules[i].module_name == arrayOfModules[index].module_name) { MessageBox.Show("Error:\r\nModule already selected"); result = false; break; }
                        if (arrayOfModules[index].module_semester == arrayOfChosenModules[i].module_semester)
                        {
                            if (arrayOfModules[index].module_lectures == arrayOfChosenModules[i].module_lectures) { MessageBox.Show("Error: \r\nModule cannot be selected because it clashes with: " + arrayOfChosenModules[i].module_name); result = false; break; }
                            if (arrayOfModules[index].module_tutorials == arrayOfChosenModules[i].module_tutorials) { MessageBox.Show("Error: \r\nModule cannot be selected because it clashes with: " + arrayOfChosenModules[i].module_name); result = false; break; }
                            if (arrayOfModules[index].module_tutorials == arrayOfChosenModules[i].module_lectures) { MessageBox.Show("Error: \r\nModule cannot be selected because it clashes with: " + arrayOfChosenModules[i].module_name); result = false; break; }
                            if (arrayOfModules[index].module_lectures == arrayOfChosenModules[i].module_tutorials) { MessageBox.Show("Error: \r\nModule cannot be selected because it clashes with: " + arrayOfChosenModules[i].module_name); result = false; break; }
                        }
                    }
                }
            }
            else if (isPrerequisite == false) { MessageBox.Show("Error:\r\nPrerequisite needed : " + arrayOfModules[index].module_prerequisites); result = false; }
            return result;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            
           int index=listOfChosenModules.SelectedIndex;
           if (index >= 0)
           {
               for (int i = 0; i < arrayOfModules.Length; i++) //MAINTAINING MODULE CAPACITY INTEGRITY
               {

                   if (arrayOfChosenModules[index].module_name == arrayOfModules[i].module_name)
                   {
                       int x = int.Parse(arrayOfModules[i].module_capacity);
                       x++;
                       arrayOfModules[i].module_capacity = x.ToString();
                   }

               }
              
               moduleCounter--;  
               Sched.removeItem(arrayOfChosenModules[index]);
               arrSort(listOfChosenModules.SelectedIndex);      //SORT ARRAY
               listOfChosenModules.Items.RemoveAt(index);

               
           }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = comboBox1.SelectedItem.ToString();
            if (semester == "1") { schedule1.Visible = true; schedule2.Visible = false; }
            if (semester == "2") { schedule2.Visible = true; schedule1.Visible = false; }
           
        }

        private void readXML()
        {

            String workingDir = Directory.GetCurrentDirectory();
            XmlTextReader readXML = new XmlTextReader(workingDir + @"\modules.xml");
            int counter2 = 0;
                       
            readXML.Read();

            while (readXML.Read())    
            { 
                XmlNodeType nType1 = readXML.NodeType;

                if (nType1 == XmlNodeType.Text)
                {
                   counter2++;                     /*If NodeType is Text save details according to counter*/
                         
                   if (counter2 == 1) {
                 
                            Module m = new Module();
                            m.module_code = readXML.Value;
                            arrayOfModules[counter] = m;  
                      
                   }
                   if (counter2 == 2) { arrayOfModules[counter].module_name = readXML.Value;  }
                   if (counter2 == 3) { arrayOfModules[counter].module_capacity = readXML.Value; }
                   if (counter2 == 4) { arrayOfModules[counter].module_semester = readXML.Value; }
                   if (counter2 == 5) { arrayOfModules[counter].module_prerequisites = readXML.Value; }
                   if (counter2 == 6) { arrayOfModules[counter].module_lectures = readXML.Value; }
                   if (counter2 == 7) { arrayOfModules[counter].module_tutorials = readXML.Value; counter2 = 0; counter++; }
                                       
                }
            }
                readXML.Close();



                for (int i = 0; i < arrayOfModules.Length; i++)
                {
                    if (arrayOfModules[i] != null)
                    {
                        listOfModules.Items.Add(arrayOfModules[i].module_name);
                    }
                }


            
        }
        private void arrSort(int index)
        {
            arrayOfChosenModules[index] = null;       
            for (int i = index; i < arrayOfChosenModules.Length; i++)//DELETES ARRAY ENTRY
            {
                if (arrayOfChosenModules[i] == null)                 //CHECKS IF ARRAY ENTRY IS NULL
                {
                    if (arrayOfChosenModules[i + 1] == null) { break; }//IF YES PUSH IT DO THE BOTTOM OF ARRAY
                    else if (arrayOfChosenModules[i + 1] != null)
                    {
                        arrayOfChosenModules[i] = arrayOfChosenModules[i + 1];
                        arrayOfChosenModules[i + 1] = null;
                    }
                }
            }
            

        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (moduleCounter < 8) {
                MessageBox.Show("Error:\r\nYou are required to select 8 modules");
            }
            if ((textboxID.Text == "") || (textboxname.Text == "") || (textboxsurname.Text == "")) {
                MessageBox.Show("Error:\r\nPlease fill in all the user details");
            
            }
            else if ((textboxID.Text != "") || (textboxname.Text != "") || (textboxsurname.Text != "")){
                Student student = new Student();
                student.name=textboxname.Text;
                student.surname=textboxsurname.Text;
                student.id=textboxID.Text;
                student.writeToXML(arrayOfChosenModules,arrayOfModules);
            }
        }

       
        
    }
}

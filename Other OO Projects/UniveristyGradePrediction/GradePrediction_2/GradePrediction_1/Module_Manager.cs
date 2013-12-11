using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradePrediction_1
{
     partial class Module_Manager : Form
    {
      
        public Level level;
        public string lvl_num;
        int assCounter = 0;
        int totalCredits = 0;
        int moduleCounter = 0;
        bool creditsChecked = false;

        public Module_Manager()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            checkCredits();
            if (creditsChecked == false) { MessageBox.Show("You are already taking too many credits, please remove a module"); }
            else if ((creditsChecked == true)&&(assCounter>0)) //IF THE STUDENT CAN ADD A MODULE
            {                
              if ((txt_code.Text != "") && (txt_title.Text != "") && (txt_credits.Text != ""))
                {
                    moduleCounter = list_modules.Items.Count;
                               
                    level.listOfModules[moduleCounter].code = txt_code.Text;            //SAVING MODULE DETAILS
                    level.listOfModules[moduleCounter].title = txt_title.Text;
                    level.listOfModules[moduleCounter].credits = txt_credits.Text;

                    totalCredits +=int.Parse(level.listOfModules[moduleCounter].credits); //DISPLAYIG CREDITS
                    lbl_credits.Text = "Credits: " + totalCredits;

                    if (totalCredits < 120) { lbl_credits.ForeColor = Color.Green; }
                    else if (totalCredits >= 120) { lbl_credits.ForeColor = Color.Red; }

                    list_modules.Items.Add(level.listOfModules[moduleCounter].title);//ADDING MODULE TO LIST
                    tbl_assessments.Controls.Clear();  
                    assCounter = 0;
                    
                   }

                else if ((txt_code.Text == "") || (txt_title.Text == "") || (txt_credits.Text == ""))
                {
                    MessageBox.Show("Please complete the module details");
                }
                
            }
            else if (assCounter == 0) { MessageBox.Show("Please add at least one assessment"); }
                    
                           
           
        }

        private void Add_Module_Form_Load(object sender, EventArgs e)
        {
            lbl_lvl.Text = lvl_num;
           list_modules.Items.Clear();
            moduleCounter = 0;
            for (int i = 0; i < level.listOfModules.Length; i++) {  //ADDING EXISTING MODULES TO LISTBOX
                if (level.listOfModules[i] != null) //CHECKING IF MODULE IS NOT NULL
                {
                    if (level.listOfModules[i].title != null)  //CHECKING IF MODULE TITLE IS NOT NULL
                    {
                        list_modules.Items.Add(level.listOfModules[i].title);
                        moduleCounter++;
                    }
                }
                else if (level.listOfModules[i] == null) {
                    Modules m = new Modules();
                    level.listOfModules[i] = m;
                }
                
           }
            checkCredits();
          }

        private void btn_addAssessment_Click(object sender, EventArgs e)
        {
            moduleCounter = list_modules.Items.Count;

            if (moduleCounter < 8)
            {
                int weight = 0;
                for (int i = 0; i < level.listOfModules[moduleCounter].arrayOfAssessments.Length; i++)
                {
                    if (level.listOfModules[moduleCounter].arrayOfAssessments[i] != null)
                    {
                        weight += int.Parse(level.listOfModules[moduleCounter].arrayOfAssessments[i].weight);
                    }
                }
               
                    if ((txt_aname.Text != "") && (txt_aType.Text != "") && (txt_aWeight.Text != ""))
                    {
                        Assessments a = new Assessments();  //CREATING ASSESSMENT
                        a.name = txt_aname.Text;
                        a.type = txt_aType.Text;
                        a.weight = txt_aWeight.Text;

                        weight += int.Parse(txt_aWeight.Text);
                       
                        if (weight > 100) { MessageBox.Show("The total of the assessments weight cannot exceed 100%"); }
                        else if (weight <= 100)
                        {
                        Label l1 = new Label();    //CREATING TABLE CONTROLS
                        l1.Text = txt_aname.Text;
                        Label l2 = new Label();
                        l2.Text = txt_aType.Text;
                        Label l3 = new Label();
                        l3.Text = txt_aWeight.Text;

                        tbl_assessments.Controls.Add(l1, 0, assCounter); //ADDING ASSESSMENT TO TABLE
                        tbl_assessments.Controls.Add(l2, 1, assCounter);
                        tbl_assessments.Controls.Add(l3, 2, assCounter);

                        level.listOfModules[moduleCounter].arrayOfAssessments[assCounter] = a;
                        assCounter++;

                    }
                    else if ((txt_aname.Text == "") || (txt_aType.Text == "") || (txt_aWeight.Text == ""))
                    {
                        MessageBox.Show("Please complete the assessment details");
                    }

                }
            }
         }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = list_modules.SelectedIndex;
           
            list_modules.Items.RemoveAt(index); //REMOVING MODULE FROM LISTBOX
            level.listOfModules[index] = null; //REMOVING MODULE FROM ARRAY OF MODULES

            for (int i = 0; i < level.listOfModules.Length-1; i++) { //SORTING MODULE ARRAY
                if ((level.listOfModules[i] == null)) {//PUSHING NULL MODULE TO END OF ARRAY
                    level.listOfModules[i] = level.listOfModules[i + 1];
                    level.listOfModules[i + 1] = null;
                   }
            }
            Modules m = new Modules();  //CREATING NEW MODULE AT END OF ARRAY
            level.listOfModules[level.listOfModules.Length-1] = m;

            checkCredits();

       }
         
        private void checkCredits() {
            totalCredits = 0;
            for (int i = 0; i < level.listOfModules.Length; i++) {             //CHECKING IF USER CAN ADD A MODULE
                if (level.listOfModules[i].credits != null) {
                    totalCredits += int.Parse(level.listOfModules[i].credits);
                    }
            }
            if (totalCredits < 120) { creditsChecked = true; }
            else if (totalCredits >= 120) {creditsChecked = false; }

            lbl_credits.Text = "Credits: " + totalCredits.ToString();
            if (totalCredits < 120) { lbl_credits.ForeColor = Color.Green; }
            else if (totalCredits >= 120) { lbl_credits.ForeColor = Color.Red; }

                         
        }

    }


}

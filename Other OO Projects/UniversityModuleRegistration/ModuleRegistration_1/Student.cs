using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ModuleRegistration_1
{
    class Student
    {
        public string name;
        public string surname;
        public string id;
        Module[] chosenModules = new Module[8];


        public void writeToXML(Module[] c_Modules,Module[]new_ModList) { //SAVING STUDENT SCHEDULE TO XML
            string workingDir = Directory.GetCurrentDirectory();

        string fullXML="<?xml version='1.0' encoding='ISO-8859-1'?><Timetable><Student><Studentname>"+name+"</Studentname><Studentsurname>"+surname+"</Studentsurname><Studentid>"+id+"</Studentid>";
            string c_mods_list="";
        for(int i =0;i<c_Modules.Length;i++){
        c_mods_list=c_mods_list+"<Module><Code>"+c_Modules[i].module_code+"</Code><ModuleName>"+
            c_Modules[i].module_name+"</ModuleName><ModuleCapacity>"+c_Modules[i].module_capacity+"</ModuleCapacity><ModuleSemester>"+
            c_Modules[i].module_semester+"</ModuleSemester><ModulePrerequisites>"+c_Modules[i].module_prerequisites+
            "</ModulePrerequisites><ModuleLectureSlot>"+c_Modules[i].module_lectures+"</ModuleLectureSlot><ModuleTutorialSlot>"+
            c_Modules[i].module_tutorials+"</ModuleTutorialSlot></Module>";
        
        }
        fullXML = fullXML + c_mods_list+"</Student></Timetable>";
        string filename="\\"+id+"_Timetable.xml";
       
        System.IO.StreamWriter file = new System.IO.StreamWriter(workingDir+@filename);
        file.WriteLine(fullXML);
        file.Close();
        MessageBox.Show(workingDir+"\r\n"+filename);

        string fullXML2_head = "<?xml version='1.0' encoding='ISO-8859-1'?><Modules>"; //SAVING UPDATED MODULES LIST TO XML
        string fullXML2_body = "";
        for (int i = 0; i < new_ModList.Length; i++) { 
        fullXML2_body=fullXML2_body+"<Module><Code>"+new_ModList[i].module_code+"</Code><ModuleName>"+
            new_ModList[i].module_name+"</ModuleName><ModuleCapacity>"+new_ModList[i].module_capacity+"</ModuleCapacity><ModuleSemester>"+
            new_ModList[i].module_semester+"</ModuleSemester><ModulePrerequisites>"+new_ModList[i].module_prerequisites+
            "</ModulePrerequisites><ModuleLectureSlot>"+new_ModList[i].module_lectures+"</ModuleLectureSlot><ModuleTutorialSlot>"+
            new_ModList[i].module_tutorials+"</ModuleTutorialSlot></Module>";
        
        }
        string fullXML2 = fullXML2_head + fullXML2_body + "</Modules>";
        string filename2 = "\\modules.xml";

        System.IO.StreamWriter file2 = new System.IO.StreamWriter(workingDir + @filename2);
        file2.WriteLine(fullXML2);
        file2.Close();
        MessageBox.Show(workingDir + "\r\n" + filename2);
        }
    }
}

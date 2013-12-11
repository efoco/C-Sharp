using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using Microsoft.VisualBasic.PowerPacks;
using System.Drawing;
using System.Collections;

namespace ModuleRegistration_1
{
    class Timetable
    {
                       
       public TableLayoutPanel sch1=new TableLayoutPanel();
       public  TableLayoutPanel sch2=new TableLayoutPanel();
        
       public void createTimetable(TableLayoutPanel schedule1, TableLayoutPanel schedule2)
       {
           sch1 = schedule1;
           sch2 = schedule2;
            
        }
   
        public void addToSlot(Module m) {
            string sem="";
            string action = "add"; 
            if (m.module_semester == "1") { sem= "1"; }
            if (m.module_semester == "2") {  sem = "2"; }
            
                Label l1 = new Label();
                l1.Text = m.module_name + "\r\n     Tutorial";
                l1.Height = 48;
                l1.Width = 100;
                
                Label l2 = new Label();
                l2.Text = m.module_name + "\r\n    Lecture";
                l2.Height = 48;
                l2.Width = 100;
                
                string lec = m.module_lectures;
                string tut = m.module_tutorials;
           
            assignCoord(lec,l2,sem,action);
            assignCoord(tut,l1,sem,action);
                        
        }
        void assignCoord(string slot,Label l,string sem,string action) {
            int x = 0;
            int y = 0;
            
            switch (slot)        //ASSIGNING SLOTS TO CLASSES
            {
                case "Monday 9-11":
                    x = 0;
                    y = 0;
                    break;
                case "Monday 11-1pm":
                    x = 0;
                    y = 1;
                    break;
                case "Monday 2-4pm":
                    x = 0;
                    y = 2;
                    break;
                case "Monday 4-6pm":
                    x = 0;
                    y = 3;
                    break;
                case "Tuesday 9-11":
                    x = 1;
                    y = 0;
                    break;
                case "Tuesday 11-1pm":
                    x = 1;
                    y = 1;
                    break;
                case "Tuesday 2-4pm":
                    x = 1;
                    y = 2;
                    break;
                case "Tuesday 4-6pm":
                    x = 1;
                    y = 3;
                    break;

                case "Wednesday 9-11":
                    x = 2;
                    y = 0;
                    break;
                case "Wedenesday 11-1pm":
                    x = 2;
                    y = 1;
                    break;
                case "Wedenesday 2-4pm":
                    x = 2;
                    y = 2;
                    break;
                case "Wednesday 4-6pm":
                    x = 2;
                    y = 3;
                    break;
                case "Thursday 9-11":
                    x = 3;
                    y = 0;
                    break;
                case "Thursday 11-1pm":
                    x = 3;
                    y = 1;
                    break;
                case "Thursday 2-4pm":
                    x = 3;
                    y = 2;
                    break;
                case "Thursday 4-6pm":
                    x = 3;
                    y = 3;
                    break;
                case "Friday 9-11":
                    x = 4;
                    y = 0;
                    break;
                case "Friday 11-1pm":
                    x = 4;
                    y = 1;
                    break;
                case "Friday 2-4pm":
                    x = 4;
                    y = 2;
                    break;
                case "Friday 4-6pm":
                    x = 4;
                    y = 3;
                    break;

                       
            }
            if (action == "add") {
                switch (sem)
                {
                    case "1":
                        Control c = sch1.GetControlFromPosition(x, y);
                        if (c == null) { sch1.Controls.Add(l, x, y); }
                        else if (c != null) { sch1.Controls.Remove(c); sch1.Controls.Add(l, x, y); }
                        break;
                    case "2":
                        Control c2 = sch2.GetControlFromPosition(x, y);
                        if (c2 == null) { sch2.Controls.Add(l, x, y); }
                        else if (c2 != null) { sch2.Controls.Remove(c2); sch2.Controls.Add(l, x, y); }
                        break;
                }
            }
            if (action == "remove")
            {
                switch (sem)
                {
                    case "1":
                        Control c = sch1.GetControlFromPosition(x, y);
                        if (c == null) { }
                        else if (c != null) { sch1.Controls.Remove(c); }
                        break;
                    case "2":
                        Control c2 = sch2.GetControlFromPosition(x, y);
                        if (c2 == null) { }
                        else if (c2 != null) { sch2.Controls.Remove(c2); }
                        break;
                }
            }
        
        }

        public void removeItem(Module m) {

            string sem = "";
            string action = "remove";

            if (m.module_semester == "1") {  sem = "1"; }
            if (m.module_semester == "2") {  sem = "2"; }

                   
            string lec = m.module_lectures;
            string tut = m.module_tutorials;
            Label l1 = new Label();
            Label l2 = new Label();
            assignCoord(lec, l2, sem,action);
            assignCoord(tut, l1, sem,action);
        
        
        }
    }
}

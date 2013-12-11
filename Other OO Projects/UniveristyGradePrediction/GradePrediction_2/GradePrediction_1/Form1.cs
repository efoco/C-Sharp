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
    public partial class Form1 : Form
    {

        Level[] arrayOfLevel=new Level[3];
        Module_Manager f = new Module_Manager();

        string courseName;
        int totalCredits = 0;
        int levelCounter = 0;  
        TableLayoutPanel[] tbl = new TableLayoutPanel[3];
        TableLayoutPanel[] tblOfTotals = new TableLayoutPanel[3];
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XMLHandler readXML = new XMLHandler();

            tbl[0] = tbl_level4;
            tbl[1] = tbl_level5;
            tbl[2] = tbl_level6;

            tblOfTotals[0] = tbl_tot0;
            tblOfTotals[1] = tbl_tot1;
            tblOfTotals[2] = tbl_tot2;


            readXML.XMLexist();
            if (readXML.filexists == true)
            {
                arrayOfLevel = readXML.getData();
                courseName = readXML.courseName;
                lbl_courseName.Text = courseName; 
                buildTables(0);
                buildTables(1);
                buildTables(2);

                calculate(0);
                calculate(1);
                calculate(2);

                lbl_db.Text = "The database was loaded successfully.";
                lbl_db.ForeColor = Color.Green;
                   
            }

            

           
        }
       
        private void add_Click(object sender, EventArgs e)
        {
            addModule(0);            
            buildTables(0);
                                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addModule(1);
            buildTables(1);
        }

        private void add_lev6_Click(object sender, EventArgs e)
        {
            addModule(2);
            buildTables(2);
        }
               
        private void go1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radio_lvl4.Checked == true) {
                addModule(0);
                buildTables(0);

            }
            if (radio_lvl5.Checked == true)
            {
                addModule(1);
                buildTables(1);
            }
            if (radio_lvl6.Checked == true) 
            {
                addModule(2);
                buildTables(2);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayOfLevel.Length; i++) {
                Level level = new Level();
                arrayOfLevel[i] = level;            
            }
            courseName = "Your Course";
            lbl_courseName.Text = courseName;

            buildTables(0);
            buildTables(1);
            buildTables(2);

        }

        private void txt_courseName_TextChanged(object sender, EventArgs e)
        {
            courseName = txt_courseName.Text;
            lbl_courseName.Text = courseName;
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            saveMarks(0);
            calculate(0);
        }

        private void btn_calculate2_Click(object sender, EventArgs e)
        {
            saveMarks(1);
            calculate(1);
        }

        private void btn_calculate3_Click(object sender, EventArgs e)
        {
            saveMarks(2);
            calculate(2);
        }

       
        private void addModule(int lvl)
        {


            f.level = arrayOfLevel[lvl];
            switch (lvl)
            {
                case 0:
                    f.lvl_num = "Level: 4";
                    break;
                case 1:
                    f.lvl_num = "Level: 5";
                    break;
                case 2:
                    f.lvl_num = "Level: 6";
                    break;
            }

            f.Activate();                         //SHOW ADD MODULE FORM
            f.ShowDialog();

        }

        private void buildTables(int lvl)
        {
            levelCounter = lvl;
            TableLayoutPanel table = tbl[levelCounter];
            table.RowCount = 8;
            table.ColumnCount = 7;
            table.Controls.Clear();

            for (int i = 0; i < arrayOfLevel[levelCounter].listOfModules.Length; i++)
            {
                if (arrayOfLevel[levelCounter].listOfModules[i] != null)
                {
                    if (arrayOfLevel[levelCounter].listOfModules[i].title != null)
                    {

                        Label l = new Label();
                        l.Height = 25;
                        l.Width = 400;
                        l.Text = arrayOfLevel[levelCounter].listOfModules[i].code + "--"
                            + arrayOfLevel[levelCounter].listOfModules[i].title
                            + "\r\nCredits: " + arrayOfLevel[levelCounter].listOfModules[i].credits; ;

                        table.Controls.Add(l, 0, i);
                        for (int k = 0; k < arrayOfLevel[levelCounter].listOfModules[i].arrayOfAssessments.Length; k++)
                        {
                            if (arrayOfLevel[levelCounter].listOfModules[i].arrayOfAssessments[k] != null)
                            {
                                TableLayoutPanel p = new TableLayoutPanel();
                                p.ColumnCount = 1;
                                p.RowCount = 2;

                                Label l2 = new Label();
                                l2.Height = 40;
                                l2.Width = 200;
                                l2.Text = arrayOfLevel[levelCounter].listOfModules[i].arrayOfAssessments[k].name + "\r\n"
                                    + arrayOfLevel[levelCounter].listOfModules[i].arrayOfAssessments[k].type + "\r\nWeight: "
                                    + arrayOfLevel[levelCounter].listOfModules[i].arrayOfAssessments[k].weight + "% \r\n";
                                TextBox t = new TextBox();
                                t.Text = arrayOfLevel[levelCounter].listOfModules[i].arrayOfAssessments[k].mark;
                                t.BackColor = Color.Beige;

                                p.Controls.Add(l2);
                                p.Controls.Add(t);


                                p.Height = 200;
                                p.Width = 200;


                                table.Controls.Add(p, k + 1, i);

                            }
                        }
                    }
                }
            }


        }
                
        private void saveMarks(int lvl) {

            TableLayoutControlCollection collection = tbl[lvl].Controls;
            int number = 0;
            int number2 = 0;
            foreach (Control c in tbl[lvl].Controls)
            {        //FOR EACH CONTROL IN THE TABLE (CHANGE TBL LEVEL)
                TableLayoutPanel tb = new TableLayoutPanel();

                if (c.GetType() == tb.GetType())
                {   //IF C IS A TABLELAYOUTPANEL
                    number++;
                    TableLayoutPanelCellPosition p = tbl[lvl].GetPositionFromControl(c);
                    int x = p.Row;  //GET COORDINATES, WILL DEFINE WHICH MODULE TO CONSIDER
                    int y = p.Column;
                    //MessageBox.Show(x.ToString()+"\r\n"+y.ToString());
                    string m = "";

                    foreach (Control c2 in c.Controls)
                    { //FOR EACH CONTROL IN C
                        TextBox t = new TextBox();

                        if (c2.GetType() == t.GetType())
                        { //IF C2 IS A TEXTBOX
                            number2++;
                            m = c2.Text;
                            arrayOfLevel[lvl].listOfModules[x].arrayOfAssessments[y - 1].mark = c2.Text;
                        }
                    }


                     // MessageBox.Show(arrayOfLevel[0].listOfModules[x].arrayOfAssessments[y - 1].mark);
                }


            }
            //MessageBox.Show(number.ToString()+"\r\n"+number2.ToString());

        }

        private void calculate(int lvl) {
            double fMark = 0;
            double modCount = 0;
            tblOfTotals[lvl].Controls.Clear();
            for (int i = 0; i < arrayOfLevel[lvl].listOfModules.Length; i++)
            {
                if (arrayOfLevel[lvl].listOfModules[i] != null)
                {
                    Label l = new Label();
                    if (arrayOfLevel[lvl].listOfModules[i].totalMark() >= 40) { l.ForeColor = Color.Green; }
                    else if (arrayOfLevel[lvl].listOfModules[i].totalMark() >= 35) { l.ForeColor = Color.Yellow; }
                    else if (arrayOfLevel[lvl].listOfModules[i].totalMark() < 35) { l.ForeColor = Color.Red; }
                    l.Text = arrayOfLevel[lvl].listOfModules[i].totalMark().ToString();

                    fMark += arrayOfLevel[lvl].listOfModules[i].totalMark();
                    modCount++;
                    tblOfTotals[lvl].Controls.Add(l);
                    
                }
            }
            fMark = fMark / modCount;
            

            switch (lvl) {
                case 0: 
                    lbl_level4.Text = "Level 4 Average: " + fMark + "%"; 
                    break;
                case 1:
                     lbl_level5.Text = "Level 5 Average: " + fMark + "%"; 
                    break;
                case 2:
                     lbl_level6.Text = "Level 6 Average: " + fMark + "%"; 
                    break;
            }
          
        }
    }

    
}

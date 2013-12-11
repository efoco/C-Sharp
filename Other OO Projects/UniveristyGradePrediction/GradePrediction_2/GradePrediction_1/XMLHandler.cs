using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace GradePrediction_1
{
    class XMLHandler
    {
        public string courseName;
        Level[] arrayOfLevel = new Level[3];
        string workingDir;
        string filename;

        int moduleCounter = 0;
        int assCounter = 0;
        int levelCounter = 0;

        public bool filexists=true;

       

        public void XMLexist() {
            workingDir = Directory.GetCurrentDirectory();
            filename = workingDir + @"\database.xml";
            if (!File.Exists(filename))
            {
               
                Level level4 = new Level();
                Level level5 = new Level();
                Level level6 = new Level();

                arrayOfLevel[0] = level4;
                arrayOfLevel[1] = level5;
                arrayOfLevel[2] = level6;

               filexists = false ;
            }
            else if (File.Exists(filename)) { filexists = true; }
            
        }
        
        public Level[] getData()
        {
        workingDir = Directory.GetCurrentDirectory();
        filename = workingDir + @"\database.xml";
            XmlTextReader readXML = new XmlTextReader(filename);
           
            readXML.Read();
                //     MessageBox.Show("isReading");

                while (readXML.Read())
                {
                    XmlNodeType nType1 = readXML.NodeType;
                    if ((readXML.Name == "courseName") && (nType1 == XmlNodeType.Element))
                    {
                        readXML.Read();
                        courseName = readXML.Value;

                    }
                    if ((readXML.Name == "level4") && (nType1 != XmlNodeType.EndElement))
                    {             //FINDS LEVEL 4, ADDS TO ARRAY OF LEVELS
                        Level level4 = new Level();
                        level4.level = 4;
                        arrayOfLevel[levelCounter] = level4;
                        //           MessageBox.Show(arrayOfLevel[0].level.ToString());
                    }
                    if ((readXML.Name == "level5") && (nType1 != XmlNodeType.EndElement))
                    {
                        levelCounter++;
                        Level level5 = new Level();
                        moduleCounter = 0;
                        level5.level = 5;
                        arrayOfLevel[levelCounter] = level5;
                    }
                    if ((readXML.Name == "level6") && (nType1 != XmlNodeType.EndElement))
                    {
                        levelCounter++;
                        Level level6 = new Level();
                        level6.level = 6;
                        moduleCounter = 0;
                        arrayOfLevel[levelCounter] = level6;
                    }

                    if (nType1 == XmlNodeType.Element)
                    {


                        switch (readXML.Name)
                        {
                            case "moduleCode":
                                //                 MessageBox.Show("foundModulecode");
                                Modules m = new Modules();
                                readXML.Read();
                                m.code = readXML.Value;
                                //MessageBox.Show(m.code);
                                arrayOfLevel[levelCounter].listOfModules[moduleCounter] = m;
                                //MessageBox.Show(arrayOfLevel[0].listOfModules[0].code);
                                break;
                            case "moduleTitle":
                                //               MessageBox.Show("foundModuleTitle");
                                readXML.Read();
                                arrayOfLevel[levelCounter].listOfModules[moduleCounter].title = readXML.Value;
                                //MessageBox.Show(arrayOfLevel[moduleCounter].listOfModules[moduleCounter].title);
                                break;
                            case "credits":
                                //             MessageBox.Show("foundCredits");
                                readXML.Read();
                                arrayOfLevel[levelCounter].listOfModules[moduleCounter].credits = readXML.Value.ToString();
                                //           MessageBox.Show(arrayOfLevel[levelCounter].listOfModules[moduleCounter].credits);
                                break;
                            case "assessmentName":
                                readXML.Read();
                                Assessments ass = new Assessments();
                                arrayOfLevel[levelCounter].listOfModules[moduleCounter].arrayOfAssessments[assCounter] = ass;
                                ass.name = readXML.Value;
                                arrayOfLevel[levelCounter].listOfModules[moduleCounter].arrayOfAssessments[assCounter].name = readXML.Value;
                                //MessageBox.Show(arrayOfLevel[levelCounter].listOfModules[moduleCounter].arrayOfAssessments[assCounter].name);
                                break;
                            case "assessmentType":
                                readXML.Read();
                                arrayOfLevel[levelCounter].listOfModules[moduleCounter].arrayOfAssessments[assCounter].type = readXML.Value;
                                break;
                            case "assessmentWeighting":
                                readXML.Read();
                                arrayOfLevel[levelCounter].listOfModules[moduleCounter].arrayOfAssessments[assCounter].weight = readXML.Value;
                                break;
                            case "assessmentMark":
                                readXML.Read();
                                arrayOfLevel[levelCounter].listOfModules[moduleCounter].arrayOfAssessments[assCounter].mark = readXML.Value;
                                assCounter++;
                                break;
                        }

                    }
                    if ((nType1 == XmlNodeType.EndElement) && (readXML.Name == "module"))
                    {
                        // MessageBox.Show("hello");
                        moduleCounter++;
                        assCounter = 0;
                    }

                }

                string test = "";
                for (int i = 0; i < arrayOfLevel[0].listOfModules.Length; i++)
                {
                    if (arrayOfLevel[0].listOfModules[i] != null)
                    {
                        test = test + "\r\n" + arrayOfLevel[0].listOfModules[i].code;
                    }
                }
                // MessageBox.Show(test);
                       
            return arrayOfLevel;
        }
    }
}

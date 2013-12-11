using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace GradePrediction_1
{
    class Level
    {
       public int level;
       double level_average=0;
       double tot_weight = 0;
       public Modules[] listOfModules = new Modules[8];

       public double finalMark() {
           level_average = 0;
           tot_weight = 0;
           for (int i = 0; i < listOfModules.Length; i++)
           {
               if (listOfModules[i] != null)
               {
                   level_average = listOfModules[i].totalMark();
                   int x = int.Parse(listOfModules[i].credits);
                   tot_weight += System.Convert.ToDouble(x);
               }
           }

           MessageBox.Show(level_average.ToString());


           return level_average;
       }
    }
}

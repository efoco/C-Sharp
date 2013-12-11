using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradePrediction_1
{
    class Modules
    {
       public string code, title;
       public string credits;

       double score=0;

       public Assessments[] arrayOfAssessments = new Assessments[6];

       public double totalMark() {
           score = 0;
           for (int i = 0; i < arrayOfAssessments.Length; i++)
           {
               if (arrayOfAssessments[i] != null)
               {
                   score += arrayOfAssessments[i].toPercentage();
               }
           }

           return score;
       }
    }
}

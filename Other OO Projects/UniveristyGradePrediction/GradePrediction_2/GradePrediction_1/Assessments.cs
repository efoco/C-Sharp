using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradePrediction_1
{
    class Assessments
    {
        public string name, type, weight, mark;
        public int int_weight, int_mark;
        public double dbl_weight, dbl_mark,final;
       

        public double toPercentage() {
            
            if (mark != "") {                                 //CONVERTING TO DOUBLES
            int_mark = int.Parse(mark);
            int_weight = int.Parse(weight);
            dbl_mark = System.Convert.ToDouble(int_mark);
            dbl_weight = System.Convert.ToDouble(int_weight);
           
            }
            else if (mark == "") {
              int_mark = 0;
              int_weight = 0;
            }

            final = dbl_mark * dbl_weight / 100;
            return final;
        }
    }
}

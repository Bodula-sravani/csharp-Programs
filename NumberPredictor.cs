using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public abstract class NumberPredictor
    {

        private void unluckyNumber()
        {
             // to predict unlucky number
        }
        protected static int predictLuckyNumber(DateTime d)
        {

            int first = 0, second = 1, third=2;
            int dob = Convert.ToInt32(d.Year.ToString()+d.Month.ToString()+d.Day.ToString());
            while(third<=dob)
            {
                first = second;
                second = third;
                third = first + second;
            }

            if(Math.Abs(dob-third)>Math.Abs(dob-second))
            {
                return second;
            }
            else
            {
                return third;
            }
        }



    }
}

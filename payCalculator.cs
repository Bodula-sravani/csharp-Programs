using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public class payCalculator
    {
        public double overtimePay(float startTime , float endTime , float hourlyRate, float overtimeExtraRate) 
        {
            double pay;
            if(endTime<=17.0f)
            {
                pay = (endTime - startTime) * hourlyRate;
            }

            else
            {
                pay = (17.0f-startTime) * hourlyRate + (endTime-17.0f)*hourlyRate*overtimeExtraRate;
            }
            pay = Math.Round(pay, 2);
            Console.WriteLine($"Pay: ${pay}");
            return pay;
        }

    }
}

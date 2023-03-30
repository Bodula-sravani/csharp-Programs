using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class LuckyNumberPredictor:NumberPredictor
    {
        public int luckyNumber;
        public LuckyNumberPredictor(DateTime dob) 
        {
            luckyNumber = NumberPredictor.predictLuckyNumber(dob);
        }
    }
}

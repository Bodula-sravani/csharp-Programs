using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class AsyncEvent
    {
        public async Task stageDecoration()
        {
            Console.WriteLine("Stage is decorated");
            await Task.Delay(5000);
        }

        public async Task venueSecurity()
        {
            await stageDecoration();
            Console.WriteLine("Stage is checked for security purposes");
            await Task.Delay(2000);
        }
        public async Task chiefguestArrival()
        {
            //await venueSecurity();
            Console.WriteLine("Chief guest picked from airport");
            await Task.Delay(2000);
        }

        public async Task speechReview()
        {
             //await chiefguestArrival();
            Console.WriteLine("Chief guest speech is reviewed by PA");
        }

        public async Task chiefguestSpeech() {

            //await chiefguestArrival();
            await speechReview();
            Console.WriteLine("chief guest begins speech");
            await Task.Delay(3000);
        }

        public async Task prizesBrought()
        {
            await venueSecurity();
            Console.WriteLine("prizes are brought to venue");
        }
         
        public async Task prizeDistribute()
        {
            await prizesBrought();
            await chiefguestSpeech();
            
            Console.WriteLine("Prizes are distributed");
        }

        public async Task prepareFood()
        {
            await bringRawmaterials();
            Console.WriteLine("Food is being prepared");
            Task.Delay(1000);
        }

        public async Task bringRawmaterials()
        {
            Console.WriteLine("Raw materials are brought");
            await Task.Delay(2000);
        }

        public async void distributeFood()
        {
            //await prizeDistribute();
            //await venueSecurity();
            Task.Delay(8000);
            await prepareFood();
            Console.WriteLine("Food is distributed");
        }
    }
}

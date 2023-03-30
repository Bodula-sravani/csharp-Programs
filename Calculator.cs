using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Calculator
    {

        public delegate int delegateForAdd(int a,int b,int c=0);
        public delegate int delegateForsubtract(int a, int b, int c = 0);
        public int add(int a, int b,int c=0)
        {
            return a + b + c;
        }

        public int subtract(int a, int b,int c=0)
        {
            return a - b - c;
        }

        public void operation()
        {

            Console.WriteLine("Enter number of numbers maximum 3");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' ').ToArray(), int.Parse);
            delegateForAdd performAdd;
            delegateForsubtract performSubtract;

            Console.WriteLine("Normal operation or Opposite?\n1.Normal\n2.Opposite");
            int operationType = Convert.ToInt32(Console.ReadLine());
            if(operationType == 1)
            {
                performAdd = add;
                performSubtract = subtract;
                
            }
            else
            {
                performAdd = subtract;
                performSubtract = add;
            }

            Console.WriteLine(performAdd.Invoke(numbers[0], numbers[1], numbers[2]));
            Console.WriteLine(performSubtract.Invoke(numbers[0], numbers[1]));




        }
        /*public void normal(int a,int b,int c=0)
        {
            Console.WriteLine("normal");
            Console.WriteLine($"addition of {a} {b} {c}= {a+b+c}");
            Console.WriteLine($"subtraction of {a} {b} {c} = {a-b-c}");
        }

        public void opposite(int a,int b,int c=0)
        {
            Console.WriteLine("opposite");
            Console.WriteLine($"addition of {a} {b} {c} = {a-b-c}");
            Console.WriteLine($"subtraction of {a} {b} {c}= {a+b+c}");
        }*/


    }
}

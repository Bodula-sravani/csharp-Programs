using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class mainClass
    {

        static void Main(string[] args)
        {
            /*Program p = new Program();
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            p.spiralMatrix(a);
            int[] price = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine($"Max profit {p.stock(price)}");

            rotate r = new rotate();
            r.rotate90();*/


            /*//calculator
            Calculator c = new Calculator();
            c.operation();*/

            //Lucky number

            Console.WriteLine("Enter your DOB in format YYYY-MM-DD to predict your lucky number");
            int[] tempDate = Array.ConvertAll(Console.ReadLine().Trim().Split('-').ToArray(), int.Parse);
            DateTime dob = new DateTime(tempDate[0], tempDate[1], tempDate[2]);

            LuckyNumberPredictor LNP = new LuckyNumberPredictor(dob);

            Console.WriteLine($"Your lucky number is {LNP.luckyNumber}");


        }
    }
}

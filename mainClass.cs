using System;
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
            Program p = new Program();
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            p.spiralMatrix(a);
            int[] price = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine($"Max profit {p.stock(price)}");

            rotate r = new rotate();
            r.rotate90();
            

        }
    }
}

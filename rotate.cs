using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class rotate
    {

        public void rotate90()
        {
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] temp = new int[col,row]; // useful for rectangular matrix


            //transpose
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //(matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);

                    //Console.WriteLine(matrix[i, j] + " " + matrix[j, i]);

                    temp[j,i] = matrix[i, j];


                }
            }


            row = temp.GetLength(0);
            col = temp.GetLength(1);

            //reverse 
            for (int i = 0;i<row;i++)
            {
                for(int j=0;j<col/2;j++)
                {
                    (temp[i, j], temp[i, col-j-1]) = (temp[i, col-j-1], temp[i, j]);
                }
            }

            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.Write(temp[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }

       
    }
}

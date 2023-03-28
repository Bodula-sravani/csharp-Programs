using System.Runtime.InteropServices;

namespace Programs
{
    internal class Program
    {
        public void spiralMatrix(int[,] a)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            int rowEnd = m;
            int colEnd = n;
            int row = 0, col = 0;
            int elements = 0;
            while (elements < m * n)
            {
                for (int i = col; i < colEnd; i++)
                {
                    Console.WriteLine("At index " + row + " " + i + " " + a[row, i]);
                    elements++;
                }
                row++;
                for (int i = row; i < rowEnd; i++)
                {
                    Console.WriteLine($"At index {i}  {colEnd - 1}  {a[i, colEnd - 1]}");
                    elements++;
                }

                colEnd--;

                for (int i = colEnd - 1; i >= 0; i--)
                {
                    Console.WriteLine($"At index {rowEnd - 1}  {i}  {a[rowEnd - 1, i]}");
                    elements++;
                }
                rowEnd--;
                for (int i = 0; i < colEnd; i++)
                {
                    Console.WriteLine($"At index {rowEnd - 1}  {i} {a[rowEnd - 1, i]}");
                    elements++;
                }
                col++;
            }
        }

        public int stock(int[] price)
        {
            int maxProfit = 0;
            int Buyday = -1;
            int Sellday = -1;

            for(int i=0;i<price.Length; i++)
            {
                for(int j=i;j<price.Length;j++)
                {
                    if ((price[j] - price[i]) > maxProfit)
                    {
                        maxProfit = price[j] - price[i];
                        Buyday = i;
                        Sellday= j;

                    }
                }
            }
            Console.WriteLine($"buying day: {Buyday} selling day: {Sellday}");
            return maxProfit;
        }
        
    }
}
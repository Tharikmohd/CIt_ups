using System;
using System.Collections.Generic;
using System.Text;

namespace CItups
{
    internal class Matrixsum

    {
        static void Main()
        {
            /*int[,] array = { { 2, 5, 6 }, { 2, 6, 9 }, { 4, 8, 11 } };

            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine(sum);*/


            Console.Write("Enter the size of row : ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the size of column : ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] Twodimension = new int[row, col];

            for(int i =0; i<row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write($"Enter the row{i} and column{j} value : ");
                    Twodimension[i,j] = Convert.ToInt32(Console.ReadLine());

                    
                }
         
            }

            Console.WriteLine("2D array");

            for (int i = 0; i < row; i++)
            {
                for(int j =0; j<col; j++)
                {
                    Console.Write(Twodimension[i, j] + "\t");
                }

                Console.WriteLine();
            }


        }
    }
}
    

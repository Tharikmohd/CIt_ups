using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CItups
{
    internal class Threedimesional
    {
        static void Main()
        {
            Console.Write("Enter the Layer size : ");
            int layer = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the size of row : ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the size of column : ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,,] threedim = new int[layer, row, col];

            int sum = 0;

            for(int i=0; i<threedim.GetLength(0); i++)
            {
                for(int j = 0; j < threedim.GetLength(1); j++)
                {
                    for(int k =0; k<threedim.GetLength(2); k++)
                    {
                        Console.Write($"Enter the value of [{i},{j},{k}] : ");
                        threedim[i, j, k] = Convert.ToInt32(Console.ReadLine());

                        sum += threedim[i,j,k];
                    }
                }
            }

            Console.WriteLine(sum);

            Console.WriteLine("3d Array matrix");

            for(int i=0; i<threedim.GetLength(0); i++)
            {
                Console.WriteLine($"Layer {i}");
                for(int j=0; j<threedim.GetLength(1); j++)
                {
                    for(int k =0; k<threedim.GetLength(2); k++)
                    {
                        Console.Write(threedim[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int max = threedim[0, 0, 0];

            for(int i =0; i<threedim.GetLength(0); i++)
            {
                for(int j=0; j<threedim.GetLength(1); j++)
                {
                    for(int k=0; k<threedim.GetLength(2); k++)
                    {
                        if (threedim[i,j,k] > max)
                        {
                            max = threedim[i, j, k];
                        }
                    }
                }
            }

            Console.WriteLine("Larget value " + max);

        }
    }
}

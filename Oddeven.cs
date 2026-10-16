using System;
using System.Collections.Generic;

class Oddeven
{
    public static void Main()
    {
        Console.Write("Enter the layer count : ");
        int layer = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of row : ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of column : ");
        int col = Convert.ToInt32(Console.ReadLine());

        int[,,] values = new int[layer,row,col];

        for(int i =0; i<layer; i++)
        {
            for(int j = 0; j<row; j++)
            {
                for (int k =0; k<col; k++)
                {
                    Console.Write($"Enter the elements of array {i},{j},{k} : ");
                    values[i,j,k] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < layer; i++)
        {
            for (int j = 0; j < row; j++)
            {
                for (int k = 0; k < col; k++)
                {
                    if (values[i, j, k] % 2 == 0)
                    {
                        evenNumbers.Add(values[i, j, k]);
                    }
                    else
                    {
                        oddNumbers.Add(values[i, j, k]);
                    }
                }
            }
        }

        Console.WriteLine("Even numbers:");

        Console.WriteLine("Odd numbers (separate layer):");
    }
}
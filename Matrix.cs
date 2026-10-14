using System;
using System.Collections.Generic;
using System.Text;

namespace CItups
{
    internal class Matrix
    {
        public static void Main()
        {
            int[,] matrix = { { 2,3,4},
                                {5,6,7 },
                                {8,9,10 }};

            int sum = 0;

            for(int i=0; i < 3; i++)
            {
                for(int j =0; j< 3; j++)
                {
                    Console.Write(matrix[i,j] + "\t");

                    

                }

                Console.WriteLine();


            } 

            Console.WriteLine(sum);
        }
    }
}

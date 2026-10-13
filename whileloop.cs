using System;
using System.Collections.Generic;
using System.Text;

namespace CItups
{
    internal class whileloop
    {
        public static void Main()
        {
            /*int num = 1234;
            int sum = 0;

            while(num>0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;

            }

            Console.WriteLine(sum);*/

            Console.Write("Enter the size of row : ");
            int row = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter the size of column : ");
            int col = Convert.ToInt32 (Console.ReadLine());

            for(int i=0; i<row; i++)
            {
                for (int j=0; j<col; j++)
                {
                    for(int k=0; k<col; k++)
                    {
                        Console.Write(k);
                    }
                }

                Console.WriteLine();
            }
        }

    }
}

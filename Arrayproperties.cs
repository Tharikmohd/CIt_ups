using System;
using System.Collections.Generic;
using System.Text;

namespace CItups
{
    internal class Arrayproperties
    {
        static void Main()
        {
            int[] array = { 10, 34, 23, 87, 12, 30, 9, 53 };

            System.Array.Reverse(array);

            foreach (int i in array)
            {
                Console.Write(i + " ");

            }
        }
    }
}

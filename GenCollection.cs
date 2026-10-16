using System;
using System.Collections.Generic;
using System.Text;

namespace CItups
{
    internal class GenCollection

    {
        public static void Main()
        {
            List<int> list = new List<int>();

            list.Add(1);
            int[] val = { 1, 9, 10, 11, 12, 4, 5, 7, 8 };
            list.AddRange(val);

            list.Insert(0, 34);
            

            foreach(int i in list)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("sort");
            list.Remove(1);
            list.RemoveAt(3);
            list.Sort();

            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }

            list.Reverse();
            
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine(list.Contains(34));
            Console.WriteLine(list.IndexOf(0));

        }
    }
}

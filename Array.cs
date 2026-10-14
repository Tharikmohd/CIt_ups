using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CItups
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            /*Console.Write("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for(int i =0; i<size; i++)
            {
                Console.Write($"Enter the value of array {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for(int i=0; i< arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }*/

            Console.Write("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            /*string[] name = new string[size];

            for(int i =0; i<size; i++)
            {
                Console.Write($"Enter the array value {i} : ");
                name[i] = Console.ReadLine();

            }

            Console.WriteLine("The array Value : ");
            for(int i =0; i < name.Length; i++)
            {
                Console.Write(name[i] + ",");
            }*/

            int[] value = new int[size];

            for(int i =0; i<size; i++)
            {
                Console.Write("Enter the value : ");
                value[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("The array value :");

            for(int i =0; i<value.Length; i++)
            {
                Console.Write(value[i] + " ");
            }

            

            int max = value[0];

            for(int i=0; i<size; i++)
            {
                if (value[i] > max)
                {
                    max = value[i];
                }
            }

            Console.WriteLine($"The maximum value {max}");


           
        }
    }
}

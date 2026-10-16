using System;
using System.ComponentModel.DataAnnotations;

class Stringarray
{
    static void Main()
    {
        //Console.Write("Enter the size of array : ");
        //int size = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of row : ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of column : ");
        int col = Convert.ToInt32(Console.ReadLine());

        string [,] names = new string [row,col];

        for(int i=0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                Console.Write($"Enter the value of names{i},{j} : ");
                names[i,j] = Console.ReadLine();
            }
        }

        Console.WriteLine("Array using String value : ");

        for(int i=0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                

                Console.Write(names[i,j] +"\t");
            }

            Console.WriteLine();
        }

        Console.Write("Length of array");

        int name = names.Length;
        Console.WriteLine(name);

        int lengthofname =names.GetUpperBound(1);
        Console.WriteLine(lengthofname);

        Console.WriteLine("Length of string");
       


    }
}
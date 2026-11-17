using System;

namespace ExceptionHandling
{
    class Exception
    {

        public static void Main()
        {
            Console.Write("Enter the num1 value : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the num2 value : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Addition \n 2.Subtract \n 3.Multiplication  \n 4.Division \n 5.Modulus");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice ==1)
            {
                int result = num1 + num2;
                Console.WriteLine(result);
            }
            else if(choice == 2)
            {
                int result = num1 - num2;
                Console.WriteLine(result);
            }
            else if (choice == 3)
            {
                int result = num1 * num2;
                Console.WriteLine(result);
            }
            else if(choice == 4)
            {
                try
                {
                    int result = num1/num2;
                    Console.WriteLine(result);
                }
                catch
                {
                    Console.WriteLine($"Division is not possible with zero value");
                    do
                    {
                        Console.Write("Enter the num2 value : ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    while(num2 ==0);
            
                }
                finally
                {
                    int result = num1/num2;
                    Console.WriteLine(result);
                }
            }
            else if(choice == 5)
            {
                int result = num1 % num2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }


    }
}
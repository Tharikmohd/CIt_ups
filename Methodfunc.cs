using System;
using System.Collections.Generic;
using System.Text;

namespace CItups
{
    internal class Methodfunc
    {
        public static void Main()
        {
            Methodfunc method = new Methodfunc();
            /*Add();
            method.Sub();
            Console.WriteLine(Mul(23, 34));
            method.Div();*/

            int a = 10;
            Console.WriteLine(a);
            method.value(a);
            Console.WriteLine(a);

            int b = 678;
            Console.WriteLine(b);
            method.refer(ref  b);
            Console.WriteLine("function value " +b);

            int result;
            method.oute(23, out result);
            Console.WriteLine(result);

            defaults();


        }

        public static void Add()
        {
            Console.Write("Enter the value 1 : ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value 2 : ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            int result = value1 + value2;

            Console.WriteLine(result);

        }

        public void Sub()
        {
            Console.Write("Enter the value 1 : ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value 2 : ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            int result = value1 - value2;

            Console.WriteLine(result);

        }

        public static int Mul(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public int Div()
        {
            Console.Write("Enter the value 1 : ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value 2 : ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            int result = value1 / value2;
            Console.WriteLine(result);

            return result;

        }

        public  void  value(int a )
        {
            a *= a;

            Console.WriteLine(a);
        }

        public void refer(ref int b)
        {
            b *= 2;
            Console.WriteLine("refer value " + b);

        }

        public void oute(int b, out  int a)
        {
            a = b + 10;

        }

        public static void defaults(int a = 5, int b =6)
        {
             a = 10;


            int result = a*b;
            Console.WriteLine(result);

        }
    }
}

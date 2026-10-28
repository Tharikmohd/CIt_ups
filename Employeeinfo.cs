using System;

namespace Employees
{
    partial class Chennai
    {
        public string name = "Mohammad";
        public int id = 23;
        public string dept = "IT";

        public  void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(dept);
        }
    }
}
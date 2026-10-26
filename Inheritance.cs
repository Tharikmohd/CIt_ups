using System;

class Inheritance
{
    public static void Main()
    {
        PayrollHR hr = new PayrollHR();
        Manager manager = new Manager();

        hr.Idshow();
        
        hr.Showdetails();
        manager.Idshow();
        manager.show();
        
        
    }
}

class Employee
{
    public string name = "Arjun";
    public string department = "IT";

    public void Idshow()
    {
        Console.WriteLine("Employee on Tech Department");
    }
}

class Manager : Employee
{
    public string project = "Quality Test";

    public void show()
    {

        Console.WriteLine("Employee working on Quality Team");
    }
}

class PayrollHR : Employee
{
    public double salary = 34500.34;

    public void Showdetails()
    {
        Console.WriteLine("Employee name = " +name);
        Console.WriteLine("Department = " +department);
        Console.WriteLine("Salary = " +salary);
    }
}
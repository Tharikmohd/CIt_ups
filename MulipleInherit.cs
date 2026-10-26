using System;
using System.IO.Compression;

class MultipleInherit
{
    public static void Main()
    {
        Chairman chairman = new Chairman();

        chairman.Listening();
        chairman.Teaching();
        chairman.Monitor();
        chairman.Getdetails();
        chairman.OverallMonitor();
        chairman.Manage();
        
    }
}

interface IStudent
{
    public void Listening();
}
interface ITeacher
{
    public void Teaching();
}
interface IHod
{
    public void Monitor();
}
interface IAdmin
{
    public void Getdetails();
}
interface IPrincipal
{
    public void OverallMonitor();
}

class Chairman : IStudent, ITeacher, IAdmin, IHod, IPrincipal
{
    public void Listening()
    {
        Console.WriteLine("Student Listening the class and take notes");
    }

    public void Teaching()
    {
        Console.WriteLine("Staff Teach the lesson and give task to students");
    }
    public void Monitor()
    {
        Console.WriteLine("Hod Monitor the staff and stuents, allocate the staff to class");
    }
    public void Getdetails()
    {
        Console.WriteLine("Admin Team collect the details about students and staff store the datas");
    }
    public void OverallMonitor()
    {
        Console.WriteLine("Manage the all staff and students");
    }

    public void Manage()
    {
        Console.WriteLine("Chairman conduct meeting with hod and principal");
    }
}
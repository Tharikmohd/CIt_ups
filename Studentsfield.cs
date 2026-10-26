using System;


class Student
{
    public string name; // field
    public int age; // field
}
class Studentfield
{
    public static void Main()
    {
        Student s1 = new Student();
        s1.name = "Gowtham";
        s1.age =23;

        Console.WriteLine($"{s1.name} - {s1.age}");
    }
   

}
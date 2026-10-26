using System;

class Abstraction
{
    public static void Main()
    {
        Mechatronics mct = new Mechatronics();
        Mech mech = new Mech();
        IT it = new IT();

        mct.Work();
        mct.Show();
        mech.Work();
        mech.Show();
        it.Work();
        it.Show();
    }
}

abstract class Staff
{
    public abstract void Work();

    public void Show()
    {
        Console.WriteLine();
    }
}

class Mechatronics : Staff
{
    public override void Work()
    {
        Console.WriteLine("Staff Conducted first hour Test.");
        Console.WriteLine("Staff's are completed their respective subjects");
        Console.WriteLine("Staff's are  trained the  student to R0botics Competition");
    }
}

class IT : Staff
{
    public override void Work()
    {
        Console.WriteLine("Staff Conducted Final year Project Review.");
        Console.WriteLine("Staff A conducted Daily test");
        Console.WriteLine("Staff's are trained the students to Hackathon Competition");
    }
}

class Mech : Staff
{
    public override void Work()
    {
        Console.WriteLine("Staff's conducted semi project review");
        Console.WriteLine("Staff's are helping SAE Students for their All India vehile building Competition");
        Console.WriteLine("Staff's are Conducted Parent Teacher Meeting to their respective Class");
    }
}
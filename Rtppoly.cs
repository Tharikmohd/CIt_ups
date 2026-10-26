using System;

class Rtppoly
{
    public static void Main()
    {
        Gokul g = new Gokul();
        Console.WriteLine("-----");
        //g.Teaching();
        Gokul g1 = new Department();
        Console.WriteLine("-----");
        //g1.Teaching();
        Gokul g2 = new Placement();
        //g2.Teaching();
        Console.WriteLine("-----");
        Gokul g3 = new Admission();
        g3.Teaching();
    }
}

class Gokul
{
    public virtual void Teaching()
    {
        Console.WriteLine("Gokul handle Robotics Lab in COE");
    }
}

class Department : Gokul
{
    public override void Teaching()
    {
        base.Teaching();
        Console.WriteLine("Gokul will handle the core subject in department");
    }
}

class Placement : Department
{
    public override void Teaching()
    {
        base.Teaching();
        Console.WriteLine("Gokul will handle the MCT department placement work ");
    }
}

class Admission : Placement
{
    public sealed override void Teaching()
    {
        base.Teaching();
        Console.WriteLine("Gokul will handle the Admission for MCT Department");
    }
}
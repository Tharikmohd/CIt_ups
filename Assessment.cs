using System;


class Base
{
    public Base()
    {
        Console.Write("Base ");
        Init();
    }

    public virtual void Init()
    {
        Console.Write("BaseInit ");
    }
}

class Derived : Base
{
    
    int x = 5;

    public Derived()
    {
        Console.Write("Derived ");
    }

    public override void Init()
    {
        Console.Write("DerivedInit" + x + " ");
    }
    
}

class MainProg
{
    public static void Main()
    {
        new Derived();
        
    }
}
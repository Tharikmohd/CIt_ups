using System;

class Abstractinter
{
    public static void Main()
    {
        
    }
}

interface Istd

{
    public void Action();
}

interface IStaff
{
    public void Work();
}

interface IHodd
{
    public void Mge();
}

class MD : Istd, IHodd, IStaff
{
    public void Action()
    {
        Console.WriteLine("Students are studing");
    }
    public void Work()
    {
        Console.WriteLine("Staff's are conduct exam");
    }
    public void Mge()
    {
        Console.WriteLine("All Dept Hod attend Meeting");
    }

    public void Cmge()
    {
        Console.WriteLine("Chairman conduct meeting with all dept Hod");
    }
}
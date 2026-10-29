using System;

class College
{
   public class Dept
    {
        public string dept = "Mechatronics";
        public int std_count = 60;

    }

    
}

class Overall 
{
    public static void Main()
    {
        College.Dept clgdept = new College.Dept();

        Console.WriteLine(clgdept.dept);

        Ece.Add(5,6);
        EEE<int> eee = new EEE<int>(45);
        EEE<string> eee1 = new EEE<string>("Hello Cit");
        eee.Display();
        eee1.Display();
        
    }
}

static class Ece
{
    public static int Add(int a, int b)
    {
        return a+b;
    }
}

sealed class Aids : College
{
    public int count = 56;

}

class EEE<T>
{
    public T Value;
    
    public EEE(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine(Value);
    }
}

using System;
using System.Diagnostics;
using System.Text;

class Stringbuild
{
    public static void Main()
    {
        string input = "Hello";
        StringBuilder sbuilder = new StringBuilder(50);
        Console.WriteLine("Capacity of memory : " +sbuilder.Capacity);

        Stopwatch sw = new Stopwatch();
        Stopwatch sw1 = new Stopwatch();

        // sbuilder.Append("Welome to C# progrmming language training at Chennai institue of technology, kundrathur, kancheepuram");
        // sbuilder.AppendFormat("Age {0}", 20 );
        // Console.WriteLine(sbuilder);
        // sbuilder.Replace("Chennai", "Cit");
        // Console.WriteLine(sbuilder);
        // sbuilder.Remove(1,25);
        // Console.WriteLine(sbuilder);
        // sbuilder.Insert(4, "CSE");
        // Console.WriteLine(sbuilder);
        // Console.WriteLine("Capacity of memory : " +sbuilder.Capacity);

        sw.Start();
        for(int i=0; i<25000; i++)
        {
            input+=i;
        }
        sw.Stop();

        sw1.Start();
        for(int i =0; i<25000; i++)
        {
            sbuilder.Append(i);
        }
        sw1.Stop();

        Console.WriteLine("String timinig " +sw.ElapsedMilliseconds);
        Console.WriteLine("String timinig " +sw1.ElapsedMilliseconds);

        Console.WriteLine(sbuilder.Capacity);
        Console.WriteLine(sbuilder.MaxCapacity);

    }
}
 using System;

 enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Enumclass
{
    public static void Main()
    {
         Console.WriteLine((Days)1);

        for(int i =0; i<7; i++)
        {
            Console.WriteLine($"Days {i} : {(Days)i}");
        }
        
    }
}
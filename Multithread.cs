using System;

class Multithread
{
    public void Testing1()
    {
        Console.WriteLine($"Testing 1 started {Thread.CurrentThread.Name}");
        for(int i =0; i<15; i++)
        {
            Console.WriteLine($"Testing 1 : {i}");
        }
        Console.WriteLine("Testing 1 Ended");
    }
    public void Testing2()
    {
        Console.WriteLine($"Testing 2 started " + Thread.CurrentThread.Name);
        for(int i =0; i<15; i++)
        {if(i == 6)
            {
                Thread.Sleep(5000);
            }

            Console.WriteLine($"Testing 2 : {i}");
        }
        Console.WriteLine("Testing 2 Ended");
    }
    public void Testing3()
    {
        Console.WriteLine($"Testing 3 started {Thread.CurrentThread.Name}");
        for(int i =0; i<15; i++)
        {
            Console.WriteLine($"Testing 3 : {i}");
        }
        Console.WriteLine("Testing 3 Ended");
    }
    public void Testing4()
    {
        Console.WriteLine($"Testing 4 started {Thread.CurrentThread.Name}");
        for(int i =0; i<15; i++)
        {
            Console.WriteLine($"Testing 4 : {i}");
        }
        Console.WriteLine("Testing 4 Ended");
    }

    public void College()
    {
        lock(this)
        {
            Console.WriteLine("CSE Department");
            Thread.Sleep(4000);
            Console.WriteLine("IT Department");
        }
        
    }
}

class Mutlithreaddemo
{
    public static void Main()
    {
        Multithread mt = new Multithread();
        Thread.CurrentThread.Name = "CIT";

        Console.WriteLine("Bus started" + Thread.CurrentThread.Name);

        ThreadStart ts = new ThreadStart(mt.College);
        Thread t = new Thread(mt.Testing1);
        Thread t1 = new Thread(new ThreadStart(mt.Testing2));
        Thread t2 = new Thread(mt.Testing3);        
        Thread t3 = new Thread(mt.Testing4);
        Thread t4 = new Thread(mt.College);
        

        t.Name = "Chennai";
        t1.Name = "Central";
        t2.Name = "Velachery";
        t3.Name = "vadapalani";

        t1.Priority = ThreadPriority.Normal;
        t2.Priority = ThreadPriority.Highest;
        t3.Priority = ThreadPriority.Lowest;
        t4.Priority = ThreadPriority.Highest;

        t.Start();
        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

        
        


        t.Join();
        t1.Join();
        // t2.Join();
        // t3.Join();

        Console.WriteLine("Bus stopped");
    }
}


using System;

public record class Patient(string name, int age)
{
    public string dept {get; init;} = "General";

    public void Display()
    {
        Console.WriteLine($"Name : {name}, Age : {age}, Department : {dept}");
    }
}

class Recordclass
{
    public static void Main()
    {
        Patient p1 = new Patient("Adhi", 25)
        {
            dept = "Ortho"
        };

        Patient p2 = new Patient("Vikram", 29);

        p1.Display();
        p2.Display();

        p2 = p2 with{dept = "Cardiology"};

        Console.WriteLine(p1);
        Console.WriteLine(p2);

        Intialize inti = new Intialize
        {
            name ="Kiran",
            id = 23
        };
        Console.WriteLine(inti.name);
        Console.WriteLine(inti.id);

        List<int> lists = new List<int>
        {
            23,34,56,76,78,98
        };

        Dictionary<int, string> dt = new Dictionary<int, string>
        {
            {1, "mohammad"},
            {2, "Gowtham"}
        };

        foreach(int num in lists)
        {
            Console.WriteLine(num);
        }

        foreach(var num in dt)
        {
            Console.WriteLine(num);
        }
    }
}

class Intialize
{
    public string name;
    public int id;

    public void Demo()
    {
        this.name = name;
        this.id = id;
    }
}

class Collector
{
    List<int> list = new List<int>();
}

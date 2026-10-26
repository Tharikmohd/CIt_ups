using System;
using System.Runtime.ConstrainedExecution;

class Constructorss // class
{
    string? name;
    int? age;
    //Default Constructor
    /*public Constructorss() // define construct 
    {
        Console.WriteLine("Default Constructor created...");
    }

    //Parametrized Constructor

    public Constructorss(string name, int age )
    {
        this.names = name;
        age1 = age;
        
    }

    public Constructorss(Constructorss obj)
    {
        names = obj.names;
        age1 = obj.age1;
    }

    //static Constructor

    static Constructorss()
    {
        Console.WriteLine("Static Constructor");
    }

    //private Constructor

    private Constructorss()
    {
        Console.WriteLine("Private Constructor Intialised..");
    }

    public static void Create()
    {
        Constructorss c2 = new Constructorss();
    }

    public void Display()
    {
        Console.WriteLine(names);
        Console.WriteLine(age1);
    }*/

    //Cosnstructor overloading

    public Constructorss()
    {
        name = "Giri";
        
    }

    public Constructorss(string names)
    {
        name = names;
        
    }
    
    public Constructorss(string names, int age1)
    {
        name = names;
        age = age1;
        
    }

    public void Display()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
    }


    public static void Main()
    {
        /*Constructorss consts = new Constructorss("arjun", 23);
        Constructorss consts1 = new Constructorss(consts);
        Constructorss c1 = new Constructorss();


        consts1.Display();*/

        Constructorss c1 = new Constructorss();
        Constructorss c2 = new Constructorss("Vasanth");
        Constructorss c3 = new Constructorss("Ramesh", 23);

        c1.Display();
        c2.Display();
        c3.Display();
    }
}
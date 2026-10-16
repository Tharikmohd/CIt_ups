using System;
using System.Collections.Generic;
using System.Collections.Specialized;

class Genericcolloection
{
    public static void Main()
    {
        List<int> list = new List<int>();

        list.Add(23);
        list.Add(45);
        list.Add(98);

        foreach(int item in list)
        {
            Console.WriteLine(item + " ");
        }

        list.Remove(23);

        foreach(int item in list)
        {
            Console.WriteLine(item + " ");
        }

        Console.WriteLine("Add using add range : ");
        int[] num = {34,54,89,90,100};

        list.AddRange(num);

        foreach(int item in list)
        {
            Console.WriteLine(item + " ");
        }

        Console.WriteLine("Removing element using index : ");

        list.RemoveAt(4);

        foreach(int item in list)
        {
            Console.WriteLine(item + " ");
        }

        Console.WriteLine("Removing element using range : ");

        list.RemoveRange(1,3);

        foreach(int item in list)
        {
            Console.WriteLine(item + " ");
        }

        HashSet<string> fruits = new HashSet<string>();

        fruits.Add("Apple");
        fruits.Add("Orange");
        fruits.Add("Mango");
        fruits.Add("Bannana");
        fruits.Add("Kiwi");
        fruits.Add("Orange");
        fruits.Add("Guava");


        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

            int index =0;

        foreach(string fruit in fruits)
        {
            Console.WriteLine($"{index} : {fruit}");
            index++;
        }

        Console.WriteLine("count = " +fruits.Count);
        Console.WriteLine("Capacity = " +fruits.Capacity);

        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(101,"");
        dict.Add(123,"chennai");
        dict.Add(145,"CSE");
        dict.Add(129,"MCT");
        dict.Add(112,"Mech");
        dict.Add(120,"It");

        foreach(object item in dict)
        {
            Console.WriteLine(item);
        }

        dict.Remove(101);

        LinkedList<int> val = new LinkedList<int>();

        val.AddFirst(23);
        val.AddLast(34);
        val.AddFirst(56);

        LinkedListNode<int> node = val.Find(56);

        if(node != null)
        {
            val.AddBefore(node,89);
        }
        foreach(int items in val)
        {
            Console.WriteLine(items);
        }

        val.Remove(34);

        foreach(int items in val)
        {
            Console.WriteLine(items);
        }

        SortedDictionary<int, string> setdict = new SortedDictionary<int, string>();

        setdict.Add(102,"chennai");
        setdict.Add(23,"madurai");
        setdict.Add(4,"tambaram");
        setdict.Add(1,"vellore");

        foreach(object items in setdict)
        {
            Console.WriteLine(items);
        }

        SortedList<int, string> listst = new SortedList<int, string>();

        listst.Add(103,"kanyakumari");
        listst.Add(109,"erode");
        listst.Add(3,"tiruppur");

        foreach(object items in listst)
        {
            Console.WriteLine(items);
        }

        Stack<int> stk = new Stack<int>();

        stk.Push(23);
        stk.Push(89);
        stk.Push(78);

        foreach(int items in stk)
        {
            Console.WriteLine(items);
        }

        Console.WriteLine(stk.Peek());

        Queue<string> qt = new Queue<string>();

        qt.Enqueue("java");
        qt.Enqueue("python");
        qt.Enqueue("CS");
        qt.Enqueue("R");

        foreach(string items in qt)
        {
            Console.WriteLine(items);
        }

        

            
    }


}

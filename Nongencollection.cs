using System;
using System.Collections;
using System.Data;
using System.Globalization;

class Nongencollection
{
    public static void Main()
    {
        /*ArrayList val = new ArrayList();

        val.Add("chennai");
        val.Add(23);
        val.Add(23.4f);
        val.Add(4500.34);
        val.Add(true);
        val.Add(4500.45m);

        foreach(object obj in val)
        {
            Console.Write(obj +" ");
        }
        Console.WriteLine();
        Console.WriteLine("After Add Range ");
        int [] num = {1,2,3,4,5};

        val.AddRange(num);



        foreach(object obj in val)
        {
            Console.Write(obj +" ");
        }
        Console.WriteLine();

       

        Console.WriteLine("Count of element : " + val.Count);
        Console.WriteLine("Capacity of Array : " + val.Capacity);

        val.Remove(true);
        val.RemoveAt(5);

        foreach(object obj in val)
        {
            Console.Write(obj +" ");
        }
        Console.WriteLine();
        Console.WriteLine("After removerange");
         val.RemoveRange(2,3);
        foreach(object obj in val)
        {
            Console.Write(obj +" ");
        }
        Console.WriteLine();

        Hashtable datas = new Hashtable();

        datas.Add(101,"chennai");
        datas.Add(102,"madurai");
        datas.Add(103,"kovai");
        datas.Add(104,"Salem");
        datas.Add(105,"kanyakumari");

        

        foreach(object obj in datas)
        {
            Console.WriteLine(obj);
        }

         foreach(object obj in datas.Keys)
        {
            Console.WriteLine(obj);
        }

        foreach(object obj in datas.Values)
        {
            Console.WriteLine(obj);
        }

        datas.Remove(101);

        foreach(object obj in datas)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine(datas.IsReadOnly);
        Console.WriteLine(datas.IsFixedSize);
        Console.WriteLine(datas.IsSynchronized);

        ArrayList val = new ArrayList();

        Console.Write("Enter the size of array list : ");
        int size = Convert.ToInt32(Console.ReadLine());

        for(int i=0; i<size; i++)
        {
            Console.Write("Enter the elements");
            val.Add(Console.ReadLine());
        }

        foreach(object item in val)
        {
            Console.WriteLine(item +" ");
        }
        
        Console.Write("Enter the elements to remove : ");
        var removeelm = Console.ReadLine();

        if(val.Contains(removeelm))
        {
            val.Remove(removeelm);
            foreach(object item in val)
            {
                Console.WriteLine(item + " ");
            }
        }
        else
        {
            Console.WriteLine("Value not found in list");
        }


            SortedList list = new SortedList();

            list.Add(85, "kundrathur");
            list.Add(02,"Annanagar");
            list.Add(15,"Tiruvanmiyur");
            list.Add(68,"Kumbakonam");
            list.Add(09, "Tiruvanmiyur");
            list.Add(10, "Virugambakkam");
            list.Add(1, "Cetral");

            foreach(object item in list)
        {
            Console.WriteLine(item);
        }

            Console.WriteLine("After remove");
        list.Remove(10);

            foreach(object item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("After remove with index");
        list.RemoveAt(2);
        foreach(object item in list)
        {
            Console.WriteLine(item);
        }

        Stack slt = new Stack();

        slt.Push(23);
        slt.Push("Hello");
        slt.Push("CIT");
        slt.Push(2104);
        slt.Push(2132);
        slt.Push("Chennai");

        foreach(object item in slt)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Remove " + slt.Pop());
        Console.WriteLine("top position " + slt.Peek());*/

        Queue cit = new Queue();

        cit.Enqueue("Chennai");
        cit.Enqueue("cse");
        cit.Enqueue("it");
        cit.Enqueue("aids");
        cit.Enqueue("mct");

        foreach(object item in cit)
        {
            Console.WriteLine(item + " ");
        }

        cit.Dequeue();

        


        

        



    }
}
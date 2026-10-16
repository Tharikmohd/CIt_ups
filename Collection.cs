using System;
using System.Collections;

namespace CItups
{
    internal class Collection
    {
        public static void Main()
        {
            /*ArrayList datas = new ArrayList();
            Console.Write("Enter the staring size of list : ");
            int size = Convert.ToInt32(Console.ReadLine());


            for(int i = 0; i<size; i++)
            {
                Console.Write("Enter the elements : ");
                datas.Add(Console.ReadLine());
            }

            foreach(object i in datas)
            {
                Console.WriteLine(i + " ");
            }

            int[] numbers = { 1, 3, 45, 65};
            datas.Add("hello");
            datas.Add(23);
            datas.AddRange(numbers);

            string[] other = { "hello", "chennai" };

            datas.AddRange(other);

            datas.RemoveAt(2);
            datas.Remove(23);
            datas.Reverse();

            foreach( object items in datas)
            {
                Console.WriteLine(items);
            }*/

            /* Hashtable dict = new Hashtable();

             dict.Add(101, "chennai");
             dict.Add(102, "trichy");
             dict.Add(103, "Covai");

             foreach(object key in dict.Keys)
             {
                 Console.WriteLine(key);
             }
             foreach (object value in dict.Values)
             {
                 Console.WriteLine(value);
             }

             dict.Remove(101);
             dict.GetEnumerator();
             foreach (object values in dict)
             {
                 Console.WriteLine(values);
             }*/

            /*SortedList slt = new SortedList();

            slt.Add(43, "ooty");
            slt.Add(1, "trichy");
            slt.Add(34, "madurai");
            slt.Add(85, "kundrathur");
            slt.Add(2, "Anna nagar");
            
            foreach(object slto in slt.Keys)
            {
                Console.WriteLine(slto);
            }
            object ind = slt.GetByIndex(4);
            Console.WriteLine("get by index " +ind);
            foreach (object slto in slt.Values)
            {
                Console.WriteLine(slto);
            }

            slt.RemoveAt(2);
            slt.Remove(43);
            
            
            foreach (object slto in slt)
            {
                Console.WriteLine(slto);
            }*/

            /*Stack datas = new Stack();

            datas.Push(1);
            datas.Push("hello");
            datas.Push(true);

            datas.Pop();

            object [] arr = datas.ToArray();

            
            foreach(object obj in datas)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(datas.Peek());

            foreach (object obj in arr)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            foreach (object obj in datas)
            {
                Console.WriteLine( "To string " +obj.ToString());
            }*/

            /*Queue tkt = new Queue();

            tkt.Enqueue("chennai");
            tkt.Enqueue("Anna nagar");
            tkt.Enqueue("porur");
            tkt.Enqueue("Guindy");

            foreach(object otk in tkt)
            {
                Console.WriteLine(otk);
            }

            tkt.Dequeue();
            
            foreach(object obj in tkt)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine( "count" +tkt.SyncRoot);*/

            BitArray btarr = new BitArray(5);
            btarr[0] = true;
            btarr[1] = true;
            btarr[2] = false;

            btarr.Length = 2;
            for(int i = 0; i < btarr.Length; i++)
            {
                Console.WriteLine(btarr[i]);
            }
            






        }
    }
};

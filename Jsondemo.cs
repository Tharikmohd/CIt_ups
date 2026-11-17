using System;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Jsondemo
{
    class Restuarnt
    {
        public List<Foods> Tiffen {get; set;} = new();
        public List<Foods> Lunch {get; set;} = new();
        public List<Foods> Snacks {get; set;} = new();
        public List<Foods> Dinner {get; set;} = new();

    }
    class Foods
    {
        public string itemname {get; set;}
        public int price {get; set;}
        public int rating {get; set;}
        public int waitingtime {get; set;}
    }

    class Canteen
    {
        public static void Main()
        {
            Restuarnt restuarnt = new Restuarnt();

            restuarnt.Tiffen.Add(new Foods{itemname = "Idly", price= 10, rating = 5, waitingtime = 10});
            restuarnt.Tiffen.Add(new Foods{itemname = "Dosa", price= 20, rating = 5, waitingtime = 5});
            restuarnt.Tiffen.Add(new Foods{itemname = "Poori", price= 40, rating = 5, waitingtime = 5});
            restuarnt.Tiffen.Add(new Foods{itemname = "Pongal", price= 40, rating = 5, waitingtime = 2});
            restuarnt.Tiffen.Add(new Foods{itemname = "Vada", price= 10, rating = 5, waitingtime = 2});

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                TypeInfoResolver = new DefaultJsonTypeInfoResolver()
            };

            string data = JsonSerializer.Serialize(restuarnt,options);
            Console.WriteLine(data);
            File.WriteAllText("Restuarant.json", data);

            string jdata = File.ReadAllText("Restuarant.json");

            Restuarnt result = JsonSerializer.Deserialize<Restuarnt>(jdata,options);
            Console.WriteLine("Deserialized data");
            if(result != null)
            {
                foreach(Foods it in restuarnt.Tiffen)
                {
                    Console.WriteLine($"Item Name : {it.itemname}, Price : {it.price}, rating : {it.rating},  waiting time : {it.waitingtime}");
                }
            }

        }
    }
}
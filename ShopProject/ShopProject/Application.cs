using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ShopProject
{
    internal class Application
    {
        
        double CurrentOrderId = 0;
        
        Storage storage = new Storage();
        
        const string file = @"c:\\json\\s.json";
        
        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
            Formatting = Formatting.Indented
        };
        public void Display()
        {
            storage.Display();
        }
        public void Add()
        {
            Console.WriteLine("Enter what you want to add: ");
            Console.WriteLine("1 - Catalogue");
            Console.WriteLine("2 - Category");
            Console.WriteLine("3 - Product");
            Console.WriteLine("0 - Leave");
            Console.Write(">");
            int x;
            int.TryParse(Console.ReadLine(), out x);
            switch(x) 
            {
                case 0: break; 
                case 1: storage.Add(); break;
                case 2: storage.AddCategory(); break;
                case 3: storage.AddProduct(); break;
            }
        }
        public void Remove()
        {
            Console.WriteLine("Enter what you want to remove: ");
            Console.WriteLine("1 - Catalogue");
            Console.WriteLine("2 - Category");
            Console.WriteLine("3 - Product");
            Console.WriteLine("0 - Leave");
            Console.Write(">");
            int x;
            int.TryParse(Console.ReadLine(), out x);
            switch (x)
            {
                case 0: break;
                case 1: storage.Remove(); break;
                case 2: storage.RemoveCategory(); break;
                case 3: storage.RemoveProduct(); break;
            }
        }
        public void AddToOrder()
        {
            storage.AddToOrder(CurrentOrderId);
        }
        public void DisplayCurrentOrder()
        {
            storage.DisplayOrder(CurrentOrderId);
        }
        public void RemoveFromOrder()
        {
            DisplayCurrentOrder();
            storage.RemoveFromOrder(CurrentOrderId);
        }
        public void OrderSummary()
        {
            DisplayCurrentOrder();
            CurrentOrderId = 0;
        }
        public void DisplayOrders()
        {
            storage.DisplayOrders();
        }
        public void RemoveOrder()
        {
            DisplayOrders();
            storage.RemoveOrder();
        }
        public void Save()
        {
            string json = JsonConvert.SerializeObject(storage, settings);
            Console.Clear();
            File.WriteAllText(file, json);
        }
        public void Load()
        {
            string json = File.ReadAllText(file);
            storage = JsonConvert.DeserializeObject<Storage>(json, settings);
        }
        public void Run()
        {
            //Load();
            Console.Clear();
            Console.WriteLine("User?");
            Console.WriteLine("1 - Customer");
            Console.WriteLine("2 - Manager");
            Console.Write("> ");
            int user;
            int.TryParse(Console.ReadLine(), out user);
            bool run = true;
            while (run && user == 1)
            {
                Console.Clear();
                Console.WriteLine("1 - Display");
                Console.WriteLine("2 - Add product to the order");
                Console.WriteLine("3 - Remove product from the order");
                Console.WriteLine("4 - Display current order");
                Console.WriteLine("5 - Summarise current order");
                Console.WriteLine("0 - End");
                Console.Write("> ");
                int choise = 0;
                int.TryParse(Console.ReadLine(), out choise);
                switch (choise)
                {
                    case 1:
                        Display();
                        Console.ReadKey();
                        break;
                    case 2:
                        AddToOrder();
                        Console.ReadKey();
                        break;
                    case 3:
                        RemoveFromOrder();
                        Console.ReadKey();
                        break;
                    case 4:
                        DisplayCurrentOrder();
                        Console.ReadKey();
                        break;
                    case 5:
                        OrderSummary();
                        Console.ReadKey();
                        break;
                    case 0:
                        Save();
                        run = false;
                        break;
                }

            }
            while (run && user == 2)
            {
                Console.Clear();
                Console.WriteLine("1 - Add product");
                Console.WriteLine("2 - Display ");
                Console.WriteLine("3 - Remove product");
                Console.WriteLine("4 - Show list of orders");
                Console.WriteLine("5 - Remove order from list");
                Console.WriteLine("0 - End");
                Console.Write("> ");
                int choise;
                int.TryParse(Console.ReadLine(), out choise);
                switch (choise)
                {
                    case 1:
                        Add();
                        Console.ReadKey();
                        break;
                    case 2:
                        Display();
                        Console.ReadKey();
                        break;
                    case 3:
                        Remove();
                        Console.ReadKey();
                        break;
                    case 4:
                        DisplayOrders();
                        Console.ReadKey();
                        break;
                    case 5:
                        RemoveOrder();
                        Console.ReadKey();
                        break;
                    case 0:
                        Save();
                        run = true;
                        break;
                }

            }
        }
        
    }
}

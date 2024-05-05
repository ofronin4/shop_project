using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class Category
    {
        List<IProduct> products = new List<IProduct>();
        public string Category_Name { get; set; }

        public Category() { }

        public void Display()
        {
            foreach (IProduct product in products)
            {
                product.Display();
            }
        }
        public void Remove()
        {
            Console.WriteLine("Enter product Id: ");
            double id = double.Parse(Console.ReadLine());
            IProduct product = GetProduct(id);
            products.Remove(product);
            Console.WriteLine("Product removed");
        }
        public IProduct GetProduct(double id)
        {
            foreach (IProduct product in products)
            {
                if (product.PId == id) return product;
            }
            return null;
        }
        public void Add()
        {
            Console.WriteLine("Choose type of product to add:");
            Console.WriteLine("1 - Product with amount");
            Console.WriteLine("2 - Product with volume)");
            Console.WriteLine("3 - Product with weight)");
            Console.WriteLine("0 - Finish");
            Console.Write(">");
            int c;
            int.TryParse(Console.ReadLine(), out c);
            switch (c)
            {
                case 0: break;
                case 1:
                    try { CreateAmount(); }
                    catch { Console.WriteLine("Creating Error!"); }
                    break;
                case 2:
                    try { CreateVolume(); }
                    catch { Console.WriteLine("Creating Error!"); }
                    break;
                case 3:
                    try { CreateWeight(); }
                    catch { Console.WriteLine("Creating Error!"); }
                    break;
            }
        }
        public void CreateAmount()
        {
            Console.WriteLine("Enter product ID: ");
            double id = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Amount: ");
            double amount = double.Parse(Console.ReadLine());
            IProduct product = Amount.CreateAmount(id, name, price, amount);
            products.Add(product);
        }
        public void CreateVolume()
        {
            Console.WriteLine("Enter product ID: ");
            double id = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Volume: ");
            double volume = double.Parse(Console.ReadLine());
            IProduct product = Volume.CreateVolume(id, name, price, volume);
            products.Add(product);
        }
        public void CreateWeight()
        {
            Console.WriteLine("Enter product ID: ");
            double id = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Weight: ");
            double weight = double.Parse(Console.ReadLine());
            IProduct product = Weight.CreateWeight(id, name, price, weight);
            products.Add(product);
        }





    }
}

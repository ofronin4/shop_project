using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class Storage
    {
        List<Catalogue> catalogues = new List<Catalogue>();
        List<Order> orders = new List<Order>();

        public void Display()
        {
            foreach (Catalogue catalogue in catalogues)
            {
                Console.WriteLine(catalogue.Catalogue_Name);
                catalogue.Display();
            }
        }
        public void Add()
        {
            Console.WriteLine("Enter Catalogue name: ");
            string catalogue_name = Console.ReadLine();
            Catalogue catalogue = GetCatalogue(catalogue_name);
            if (catalogue == null)
            {
                catalogue.Catalogue_Name = catalogue_name;
                catalogues.Add(catalogue);
            }
        }
        public void Remove()
        {
            Console.WriteLine("Enter Catalogue name: ");
            string catalogue_name = Console.ReadLine();
            Catalogue catalogue = GetCatalogue(catalogue_name);
            if (catalogue != null)
            {
                catalogues.Remove(catalogue);
            }
        }
        public void AddCategory()
        {
            Console.WriteLine("Enter Catalogue name: ");
            string catalogue_name = Console.ReadLine();
            Catalogue catalogue = GetCatalogue(catalogue_name);
            catalogue.Add();
        }
        public void RemoveCategory()
        {
            Console.WriteLine("Enter Catalogue name: ");
            string catalogue_name = Console.ReadLine();
            Catalogue catalogue = GetCatalogue(catalogue_name);
            catalogue.Remove();
        }
        public void AddProduct()
        {
            Console.WriteLine("Enter Catalogue name: ");
            string catalogue_name = Console.ReadLine();
            Catalogue catalogue = GetCatalogue(catalogue_name);
            catalogue.AddProduct();
        }
        public void RemoveProduct()
        {
            Console.WriteLine("Enter Catalogue name: ");
            string catalogue_name = Console.ReadLine();
            Catalogue catalogue = GetCatalogue(catalogue_name);
            catalogue.RemoveProduct();
        }
        public Catalogue GetCatalogue(string catalogue_name)
        {
            foreach (Catalogue catalogue in catalogues)
            {
                if (catalogue.Catalogue_Name == catalogue_name) return catalogue;
            }
            return null;
        }
        public void AddToOrder(double CurrentOrderId)
        {
            Order order;
            if (CurrentOrderId == 0)
            {
                order = new Order();
                order.OrderId = orders.Count + 1;
                orders.Add(order);
            }
            else { order = GetOrder(CurrentOrderId); }
            Console.WriteLine("Enter product Id: ");
            double id;
            double.TryParse(Console.ReadLine(), out id);
            order.AddProduct(GetProduct(id));
        }
        public void RemoveFromOrder(double CurrentOrderId)
        {
            Order order;
            if (CurrentOrderId == 0)
            {
                order = new Order();
                order.OrderId = orders.Count + 1;
                orders.Add(order);
            }
            else { order = GetOrder(CurrentOrderId); }
            Console.WriteLine("Enter product Id: ");
            double id;
            double.TryParse(Console.ReadLine(), out id);
            order.RemoveProduct(GetProduct(id));
        }
        public void DisplayOrder(double CurrentOrderId)
        {
            Order order = GetOrder(CurrentOrderId);
            order.Display();
        }

        public void DisplayOrders()
        {
            foreach (Order order in orders)
            {
                order.Display(); 
            }
        }
        public void RemoveOrder()
        {
            Console.WriteLine("Enter id of order you want to remove:");
            double id;
            double.TryParse(Console.ReadLine(), out id);
            Order order = GetOrder(id);
            orders.Remove(order);
        }
        public Order GetOrder(double CurrentOrderId)
        {
            foreach(Order order in orders)
            {
                if (order.OrderId == CurrentOrderId) return order;
            }
            return null;
        }
        public IProduct GetProduct(double id)
        {
            foreach (Catalogue catalogue in catalogues)
            {
                return catalogue.GetProduct(id);
            }
            return null;
        }
    }
}

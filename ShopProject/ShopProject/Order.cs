using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class Order
    {
        List<IProduct> products = new List<IProduct>();
        public DateTime OrderTime { get; }
        public double OrderId { get; set; }
        public Order()
        {
            OrderTime = DateTime.Now;
        }
        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }
        public void RemoveProduct(IProduct product)
        {
            products.Remove(product);
        }


        public double Summary()
        {
            return products.Sum(orderable => orderable.PPrice);
        }

        public void Display()
        {
            Console.WriteLine($"Order Time: {OrderTime}");
            Console.WriteLine($"Order Id: {OrderId}");
            foreach (IProduct product in products)
            {
                Console.WriteLine($" - {product.PName} : {product.PPrice} $");
            }
            Console.WriteLine($"Summary: {Summary()} $");
        }
    }
}

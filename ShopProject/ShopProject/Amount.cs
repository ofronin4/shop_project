using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class Amount : IProduct
    {
        public double PId { get; set; }
        public string PName { get; set; }
        public double PPrice { get; set; }

        public double PAmount { get; set; }

        public Amount() { }

        public Amount(double pId, string pName, double pPrice, double pAmount)
        {
            PId = pId;
            PName = pName;
            PPrice = pPrice;
            PAmount = pAmount;
        }

        public void Display()
        {
            Console.WriteLine($" - Id: {PId}");
            Console.WriteLine($"   Name: {PName};");
            Console.WriteLine($"   Price: {PPrice}zl;");
            Console.WriteLine($"   Volume: {PAmount};");
        }
        public static IProduct CreateAmount(double PId, string PName, double PPrice, double PAmount)
        {
            return new Amount(PId, PName, PPrice, PAmount);
        }
    }
}

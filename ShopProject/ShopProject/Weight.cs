using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class Weight : IProduct
    {
        public double PId { get; set; }
        public string PName { get; set; }
        public double PPrice { get; set; }

        public double PWeight { get; set; }

        public Weight() { }

        public Weight(double pId, string pName, double pPrice, double pWeight)
        {
            PId = pId;
            PName = pName;
            PPrice = pPrice;
            PWeight = pWeight;
        }

        public void Display()
        {
            Console.WriteLine($" - Id: {PId}");
            Console.WriteLine($"   Name: {PName};");
            Console.WriteLine($"   Price: {PPrice}zl;");
            Console.WriteLine($"   Weight: {PWeight}g;");
        }
        public static IProduct CreateWeight(double PId, string PName, double PPrice, double PWeight)
        {
            return new Weight(PId, PName, PPrice, PWeight);
        }
    }
}

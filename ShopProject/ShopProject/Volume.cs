using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class Volume : IProduct
    {
        public double PId { get; set; }
        public string PName { get; set; }
        public double PPrice { get; set; }

        public double PVolume { get; set; }

        public Volume() { }

        public Volume(double pId, string pName, double pPrice, double pVolume)
        {
            PId = pId;
            PName = pName;
            PPrice = pPrice;
            PVolume = pVolume;
        }
        public void Display()
        {
            Console.WriteLine($" - Id: {PId}");
            Console.WriteLine($"   Name: {PName};");
            Console.WriteLine($"   Price: {PPrice}zl;");
            Console.WriteLine($"   Volume: {PVolume}ml;");
        }
        public static IProduct CreateVolume(double PId, string PName, double PPrice, double PVolume)
        {
            return new Volume(PId, PName, PPrice, PVolume);
        }
    }
}

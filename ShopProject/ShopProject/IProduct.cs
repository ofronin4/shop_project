using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    public interface IProduct
    {
        double PId { get; set; }
        string PName { get; set; }
        double PPrice { get; set; }

        void Display();


    }
}

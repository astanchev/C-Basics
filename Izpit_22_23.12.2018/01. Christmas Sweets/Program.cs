using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaklava = double.Parse(Console.ReadLine());
            double priceMuffin = double.Parse(Console.ReadLine());
            double kgStolen = double.Parse(Console.ReadLine());
            double kgBonbons = double.Parse(Console.ReadLine());
            double kgBuiscits = double.Parse(Console.ReadLine());

            double priceStolen = priceBaklava * 1.6;
            double priceBonbons = priceMuffin * 1.8;

            double sum = kgStolen * priceStolen + kgBonbons * priceBonbons + kgBuiscits * 7.5;

            Console.WriteLine($"{sum:f2}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPacketsPens = int.Parse(Console.ReadLine());
            int numberPacketsMarkers = int.Parse(Console.ReadLine());
            double litersCleaningPreparat = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double pricePens = 5.8 * numberPacketsPens;
            double priceMarkers = 7.2 * numberPacketsMarkers;
            double pricePreparat = 1.2 * litersCleaningPreparat;
            double total = (100.0 - percentDiscount) * (priceMarkers + pricePens + pricePreparat) / 100;

            Console.WriteLine($"{total:f3}");


        }
    }
}

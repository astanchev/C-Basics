using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaidenParty
{
    class MaidenParty
    {
        static void Main(string[] args)
        {
            double priceForTheParty = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keyChains = int.Parse(Console.ReadLine());
            int cartoons = int.Parse(Console.ReadLine());
            int kismets = int.Parse(Console.ReadLine());

            int totalSales = loveMessages + roses + keyChains + cartoons + kismets;
            double totalSum = loveMessages * 0.6 + roses * 7.2 + keyChains * 3.6 + cartoons * 18.2 + kismets * 22;

            if (totalSales >= 25)
            {
                totalSum *= 0.65;
                totalSum *= 0.9;
            }
            else
            {
                totalSum *= 0.9;
            }

            if (totalSum >= priceForTheParty)
            {
                Console.WriteLine($"Yes! {totalSum - priceForTheParty:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceForTheParty - totalSum:f2} lv needed.");
            }


        }
    }
}

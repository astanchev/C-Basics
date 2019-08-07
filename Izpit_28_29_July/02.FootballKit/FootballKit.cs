using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FootballKit
{
    class FootballKit
    {
        static void Main(string[] args)
        {
            double tShirtPrice = double.Parse(Console.ReadLine());
            double ammountForPrize = double.Parse(Console.ReadLine());

            double shortsPrice = 0.75 * tShirtPrice;
            double socksPrice = 0.2 * shortsPrice;
            double bootsPrice = 2.0 * (tShirtPrice + shortsPrice);
            double totalSpentMoney = tShirtPrice + shortsPrice + socksPrice + bootsPrice;
            totalSpentMoney *= 0.85;

            if (totalSpentMoney >= ammountForPrize)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalSpentMoney:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(ammountForPrize-totalSpentMoney):f2} lv. more.");
            }
        }
    }
}

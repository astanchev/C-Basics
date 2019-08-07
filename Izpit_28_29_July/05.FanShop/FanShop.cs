using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FanShop
{
    class FanShop
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());
            int price = 0;
            int spentMoney = 0;

            for (int i = 1; i <= items; i++)
            {
                string itemName = Console.ReadLine();
                switch (itemName)
                {
                    case "hoodie": price = 30; break;
                    case "keychain": price = 4; break;
                    case "T-shirt": price = 20; break;
                    case "flag": price = 15; break;
                    case "sticker": price = 1; break;
                    default: break;
                }
                spentMoney += price;
            }
            if (budget>=spentMoney)
            {
                Console.WriteLine($"You bought {items} items and left with {budget-spentMoney} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {spentMoney-budget} more lv.");
            }
        }
    }
}

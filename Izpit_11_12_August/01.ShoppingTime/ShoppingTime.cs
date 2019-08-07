using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShoppingTime
{
    class ShoppingTime
    {
        static void Main(string[] args)
        {
            int timeForBreak = int.Parse(Console.ReadLine());
            double pricePart = double.Parse(Console.ReadLine());
            double priceProgram = double.Parse(Console.ReadLine());
            double priceFrape = double.Parse(Console.ReadLine());

            double totalSpentMoney = 3*pricePart+2*priceProgram+priceFrape;
            int remainingTimeFromBreak = timeForBreak-5-3*2-2*2;

            Console.WriteLine($"{totalSpentMoney:f2}");
            Console.WriteLine($"{remainingTimeFromBreak}");

        }
    }
}

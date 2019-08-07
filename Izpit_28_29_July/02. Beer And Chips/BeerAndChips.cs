using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Beer_And_Chips
{
    class BeerAndChips
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numberBeers = int.Parse(Console.ReadLine());
            int numberChips = int.Parse(Console.ReadLine());

            double moneyForBeer = numberBeers * 1.2;            
            double chips = moneyForBeer * 0.45 * numberChips;
            double moneyForChips = Math.Ceiling(chips);
            double leftMoney = budget - (moneyForBeer + moneyForChips);

            if (leftMoney>=0)
            {
                Console.WriteLine($"{name} bought a snack and has {leftMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {Math.Abs(leftMoney):f2} more leva!");
            }

        }
    }
}

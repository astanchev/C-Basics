using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad4
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double spentMoney = 0.0;
            double price = 0.0;

            int numberBalloons = 0;
            int numberFlowers = 0;
            int numberCandles = 0;
            int ribbonLenght = 0;

            while (true)
            {
                string typeOfStock = Console.ReadLine();
                if (typeOfStock == "stop")
                {
                    Console.WriteLine($"Spend money: {spentMoney:f2}");
                    Console.WriteLine($"Money left: {budget - spentMoney:f2}");
                    break;
                }
                int numberOfStock = int.Parse(Console.ReadLine());
                switch (typeOfStock)
                {
                    case "balloons":
                        price = 0.1;
                        numberBalloons += numberOfStock;
                        break;
                    case "flowers":
                        price = 1.5;
                        numberFlowers += numberOfStock;
                        break;
                    case "candles":
                        price = 0.5;
                        numberCandles += numberOfStock;
                        break;
                    case "ribbon":
                        price = 2.0;
                        ribbonLenght += numberOfStock;
                        break;
                    default: break;
                }
                spentMoney += numberOfStock * price;
                if (spentMoney >= budget)
                {
                    Console.WriteLine("All money is spent!");
                    break;
                }
            }
            Console.WriteLine($"Purchased decoration is {numberBalloons} balloons, {ribbonLenght} m ribbon, {numberFlowers} flowers and {numberCandles} candles.");
        }
    }
    
}

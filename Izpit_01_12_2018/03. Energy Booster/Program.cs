using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int numberSets = int.Parse(Console.ReadLine());

            double price = 0.0;
            double priceSteak = 0.0;
            double totalPrice = 0.0;

            if (size == "small")
            {
                switch (fruit)
                {
                    case "Watermelon": price = 56.0; break;
                    case "Mango": price = 36.66; break;
                    case "Pineapple": price = 42.10; break;
                    case "Raspberry": price = 20.0; break;
                    default: break;
                }
                priceSteak = price * 2;
                totalPrice = priceSteak * numberSets;
            }
            else if (size == "big")
            {
                switch (fruit)
                {
                    case "Watermelon": price = 28.7; break;
                    case "Mango": price = 19.6; break;
                    case "Pineapple": price = 24.8; break;
                    case "Raspberry": price = 15.2; break;
                    default: break;
                }
                priceSteak = price * 5;
                totalPrice = priceSteak * numberSets;
            }
            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 1000)
            {
                totalPrice *= 0.5;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");


        }
    }
}

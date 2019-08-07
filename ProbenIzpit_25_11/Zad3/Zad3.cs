using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Zad3
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int numberOrders = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            double price = 0.0;

            switch (restaurant)
            {
                case "Sushi Zone":
                    switch (sushi)
                    {
                        case "sashimi": price = 4.99; break;
                        case "maki": price = 5.29; break;
                        case "uramaki": price = 5.99; break;
                        case "temaki": price = 4.29; break;
                        default: break;
                    }
                    break;
                case "Sushi Time":
                    switch (sushi)
                    {
                        case "sashimi": price = 5.49; break;
                        case "maki": price = 4.69; break;
                        case "uramaki": price = 4.49; break;
                        case "temaki": price = 5.19; break;
                        default: break;
                    }
                    break;
                case "Sushi Bar":
                    switch (sushi)
                    {
                        case "sashimi": price = 5.25; break;
                        case "maki": price = 5.55; break;
                        case "uramaki": price = 6.25; break;
                        case "temaki": price = 4.75; break;
                        default: break;
                    }
                    break;
                case "Asian Pub":
                    switch (sushi)
                    {
                        case "sashimi": price = 4.50; break;
                        case "maki": price = 4.80; break;
                        case "uramaki": price = 5.50; break;
                        case "temaki": price = 5.50; break;
                        default: break;
                    }
                    break;
                default:
                    Console.WriteLine($"{restaurant} is invalid restaurant!");
                    return;
            }

            double totalPrice = price * numberOrders;

            if (order=="Y")
            {
                Console.WriteLine($"Total price: {Math.Ceiling(1.2*totalPrice)} lv.");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");
            }





        }
    }
}

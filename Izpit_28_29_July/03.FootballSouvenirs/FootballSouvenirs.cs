using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FootballSouvenirs
{
    class FootballSouvenirs
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            double sum = 0.0;

            switch (country)
            {
                case "Argentina":
                    switch (souvenir)
                    {
                        case "flags":
                            price = 3.25;
                            break;
                        case "caps":
                            price = 7.2;
                            break;
                        case "posters":
                            price = 5.10;
                            break;
                        case "stickers":
                            price = 1.25;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            return;
                    }
                    break;
                case "Brazil":
                    switch (souvenir)
                    {
                        case "flags":
                            price = 4.2;
                            break;
                        case "caps":
                            price = 8.5;
                            break;
                        case "posters":
                            price = 5.35;
                            break;
                        case "stickers":
                            price = 1.20;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            return;
                    }
                    break;
                case "Croatia":
                    switch (souvenir)
                    {
                        case "flags":
                            price = 2.75;
                            break;
                        case "caps":
                            price = 6.9;
                            break;
                        case "posters":
                            price = 4.95;
                            break;
                        case "stickers":
                            price = 1.1;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            return;
                    }
                    break;
                case "Denmark":
                    switch (souvenir)
                    {
                        case "flags":
                            price = 3.1;
                            break;
                        case "caps":
                            price = 6.5;
                            break;
                        case "posters":
                            price = 4.8;
                            break;
                        case "stickers":
                            price = 0.9;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid country!");
                    return;
            }
            sum = price * quantity;
            Console.WriteLine($"Pepi bought {quantity} {souvenir} of {country} for {sum:f2} lv.");
        }
    }
}

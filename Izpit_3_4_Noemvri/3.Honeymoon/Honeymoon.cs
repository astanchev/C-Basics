using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Honeymoon
{
    class Honeymoon
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            double priceForExcursion = 0.0;

            double priceForCairo = numberOfNights * 500 + 600;
            double priceForParis = numberOfNights * 300 + 350;
            double priceForLima = numberOfNights * 800 + 850;
            double priceForNewYork = numberOfNights * 600 + 650;
            double priceForTokyo = numberOfNights * 700 + 700;


            switch (city)
            {
                case "Cairo":
                    priceForExcursion = priceForCairo;
                    if (numberOfNights >= 1 && numberOfNights <= 4)
                    {
                        priceForExcursion = priceForCairo * 0.97;
                    }
                    else if (numberOfNights >= 5 && numberOfNights <= 9)
                    {
                        priceForExcursion = priceForCairo * 0.95;
                    }
                    else if (numberOfNights >= 10 && numberOfNights <= 24)
                    {
                        priceForExcursion = priceForCairo * 0.90;
                    }
                    else if (numberOfNights >= 25 && numberOfNights <=49)
                    {
                        priceForExcursion = priceForCairo * 0.83;
                    }
                    else if (numberOfNights >= 50)
                    {
                        priceForExcursion = priceForCairo * 0.70;
                    }
                    break;
                case "Paris":
                    priceForExcursion = priceForParis;
                    if (numberOfNights >= 5 && numberOfNights <= 9)
                    {
                        priceForExcursion = priceForParis * 0.93;
                    }
                    else if (numberOfNights >= 10 && numberOfNights <= 24)
                    {
                        priceForExcursion = priceForParis * 0.88;
                    }
                    else if (numberOfNights >= 25 && numberOfNights <= 49)
                    {
                        priceForExcursion = priceForParis * 0.78;
                    }
                    else if (numberOfNights >= 50)
                    {
                        priceForExcursion = priceForParis * 0.70;
                    }
                    break;
                case "Lima":
                    priceForExcursion = priceForLima;
                    if (numberOfNights >= 25 && numberOfNights <= 49)
                    {
                        priceForExcursion = priceForLima * 0.81;
                    }
                    else if (numberOfNights >= 50)
                    {
                        priceForExcursion = priceForLima * 0.70;
                    }
                    break;
                case "New York":
                    priceForExcursion = priceForNewYork;
                    if (numberOfNights >= 1 && numberOfNights <= 4)
                    {
                        priceForExcursion = priceForNewYork * 0.97;
                    }
                    else if (numberOfNights >= 5 && numberOfNights <= 9)
                    {
                        priceForExcursion = priceForNewYork * 0.95;
                    }
                    else if (numberOfNights >= 10 && numberOfNights <= 24)
                    {
                        priceForExcursion = priceForNewYork * 0.88;
                    }
                    else if (numberOfNights >= 25 && numberOfNights <= 49)
                    {
                        priceForExcursion = priceForNewYork * 0.81;
                    }
                    else if (numberOfNights >= 50)
                    {
                        priceForExcursion = priceForNewYork * 0.70;
                    }
                    break;
                case "Tokyo":
                    priceForExcursion = priceForTokyo;
                    if (numberOfNights >= 10 && numberOfNights <= 24)
                    {
                        priceForExcursion = priceForTokyo * 0.88;
                    }
                    else if (numberOfNights >= 25 && numberOfNights <= 49)
                    {
                        priceForExcursion = priceForTokyo * 0.83;
                    }
                    else if (numberOfNights >= 50)
                    {
                        priceForExcursion = priceForTokyo * 0.70;
                    }
                    break;
                default:
                    break;
            }

            double moneyLeft = budget - priceForExcursion;

            if (moneyLeft>=0)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pastry_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string pastery = Console.ReadLine();
            int numberPasteries = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            double price = 0.0;
            double totalPrice = 0.0;

            switch (pastery)
            {
                case "Cake":
                    if (day <= 15)
                    {
                        price = 24.0;
                    }
                    else
                    {
                        price = 28.7;
                    }
                    totalPrice = price * numberPasteries;
                    if (day <= 22)
                    {
                        if (totalPrice >= 100 && totalPrice <= 200)
                        {
                            totalPrice *= 0.85;
                        }
                        else if (totalPrice > 200)
                        {
                            totalPrice *= 0.75;
                        }
                        if (day <= 15)
                        {
                            totalPrice *= 0.9;
                        }
                    }
                    break;
                case "Souffle":
                    if (day <= 15)
                    {
                        price = 6.66;
                    }
                    else
                    {
                        price = 9.8;
                    }
                    totalPrice = price * numberPasteries;
                    if (day <= 22)
                    {
                        if (totalPrice >= 100 && totalPrice <= 200)
                        {
                            totalPrice *= 0.85;
                        }
                        else if (totalPrice > 200)
                        {
                            totalPrice *= 0.75;
                        }
                        if (day <= 15)
                        {
                            totalPrice *= 0.9;
                        }
                    }
                    break;
                case "Baklava":
                    if (day <= 15)
                    {
                        price = 12.6;
                    }
                    else
                    {
                        price = 16.98;
                    }
                    totalPrice = price * numberPasteries;
                    if (day <= 22)
                    {
                        if (totalPrice >= 100 && totalPrice <= 200)
                        {
                            totalPrice *= 0.85;
                        }
                        else if (totalPrice > 200)
                        {
                            totalPrice *= 0.75;
                        }
                        if (day <= 15)
                        {
                            totalPrice *= 0.9;
                        }
                    }
                    break;
                default: break;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}

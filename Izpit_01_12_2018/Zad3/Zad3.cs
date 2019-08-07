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
            int daysForStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            int sleeps = daysForStay - 1;

            double price = 0.0;
            double totalSum = 0.0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    price = 18.0;
                    totalSum = price * sleeps;
                    break;
                case "apartment":
                    price = 25.0;
                    totalSum = price * sleeps;
                    if (sleeps < 10) totalSum *= 0.70;
                    else if (sleeps >= 10 && sleeps <= 15) totalSum *= 0.65;
                    else if (sleeps > 15) totalSum *= 0.50;
                    break;
                case "president apartment":
                    price = 35.0;
                    totalSum = price * sleeps;
                    if (sleeps < 10) totalSum *= 0.90;
                    else if (sleeps >= 10 && sleeps <= 15) totalSum *= 0.85;
                    else if (sleeps > 15) totalSum *= 0.80;
                    break;
                default: break;
            }
            if (feedback == "positive")
            {
                totalSum *= 1.25;
            }
            else
            {
                totalSum *= 0.9;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}

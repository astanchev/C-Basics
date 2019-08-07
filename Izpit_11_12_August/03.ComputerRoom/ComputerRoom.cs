using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComputerRoom
{
    class ComputerRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double priceForPerson = 0.0;
            double totalCosts = 0.0;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    if (dayOrNight == "day")
                    {
                        priceForPerson = 10.5;
                    }
                    else
                    {
                        priceForPerson = 8.4;
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    if (dayOrNight == "day")
                    {
                        priceForPerson = 12.6;
                    }
                    else
                    {
                        priceForPerson = 10.2;
                    }
                    break;
                default: break;
            }
            if (people >= 4)
            {
                priceForPerson *= 0.9;
            }
            if (hours >= 5)
            {
                priceForPerson *= 0.5;
            }
            totalCosts = priceForPerson * hours * people;

            Console.WriteLine($"Price per person for one hour: {priceForPerson:f2}");
            Console.WriteLine($"Total cost of the visit: {totalCosts:f2}");
        }
    }
}

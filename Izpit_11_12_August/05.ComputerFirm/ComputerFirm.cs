using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComputerFirm
{
    class ComputerFirm
    {
        static void Main(string[] args)
        {
            int numberComputers = int.Parse(Console.ReadLine());

            int rang = 0;
            double rangSum = 0.0;
            double totalSales = 0;

            for (int i = 1; i <= numberComputers; i++)
            {
                int numberOfSales = int.Parse(Console.ReadLine());
                rang = numberOfSales % 10;
                rangSum += rang;
                numberOfSales /= 10;
                double possibleSales = numberOfSales;
                switch (rang)
                {
                    case 2: possibleSales *= 0.0; break;
                    case 3: possibleSales *= 50.0 / 100; break;
                    case 4: possibleSales *= 70.0 / 100; break;
                    case 5: possibleSales *= 85.0 / 100; break;
                    case 6: possibleSales *= 1.0; break;
                    default: break;
                }
                totalSales += possibleSales;
            }
            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{rangSum / numberComputers:f2}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StadiumIncome
{
    class StadiumIncome
    {
        static void Main(string[] args)
        {
            int numberSectors = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double moneyFromSector = (stadiumCapacity * ticketPrice) / numberSectors;
            double totalProfit = moneyFromSector * numberSectors;
            double moneyForCharity = (totalProfit - 0.75 * moneyFromSector) / 8;

            Console.WriteLine($"Total income - {totalProfit:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}

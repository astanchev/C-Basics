using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TripToWorldCup
{
    class TripToWorldCup
    {
        static void Main(string[] args)
        {
            double ticketPriceForward = double.Parse(Console.ReadLine());
            double ticketPriceBackward = double.Parse(Console.ReadLine());
            double ticketPriceMatch = double.Parse(Console.ReadLine());
            int numberMatches = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double plainTicketsTotal = 6 * (ticketPriceForward + ticketPriceBackward);
            double ticketsAfterDiscount = plainTicketsTotal * ((100-percentDiscount) / 100.0);
            double ticketsForMachesSum = 6 * ticketPriceMatch * numberMatches;

            double totalSum = ticketsAfterDiscount + ticketsForMachesSum;
            double sumPerFriend = totalSum/6.0;

            Console.WriteLine($"Total sum: {totalSum:f2} lv.");
            Console.WriteLine($"Each friend has to pay {sumPerFriend:f2} lv.");

        }
    }
}

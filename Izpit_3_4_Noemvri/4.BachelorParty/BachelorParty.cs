using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BachelorParty
{
    class BachelorParty
    {
        static void Main(string[] args)
        {
            int payment = int.Parse(Console.ReadLine());
            int couvert = 0;
            int collectMoney = 0;
            int numberGuests = 0;
            int allGuests = 0;

            while (true)
            {
                string groupReservation = Console.ReadLine();
                if (groupReservation == "The restaurant is full")
                {
                    break;
                }
                numberGuests = int.Parse(groupReservation);
                if (numberGuests >= 5)
                {
                    couvert = 70;
                }
                else if (numberGuests < 5)
                {
                    couvert = 100;
                }
                collectMoney += numberGuests * couvert;
                allGuests += numberGuests;
            }
            if (collectMoney >= payment)
            {
                Console.WriteLine($"You have {allGuests} guests and {collectMoney - payment} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {allGuests} guests and {collectMoney} leva income, but no singer.");
            }
        }
    }
}

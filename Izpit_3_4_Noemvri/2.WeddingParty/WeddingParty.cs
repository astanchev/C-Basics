using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.WeddingParty
{
    class WeddingParty
    {
        static void Main(string[] args)
        {
            int numberGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double couvertsSum = numberGuests * 20;
            double leftMoney = budget - couvertsSum;

            if (leftMoney>=0)
            {
                Console.WriteLine($"Yes! {Math.Round(0.4*leftMoney)} lv are for fireworks and {Math.Round(0.6*leftMoney)} lv are for donation."); 
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(Math.Abs(leftMoney))} lv more.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double targetMoney = double.Parse(Console.ReadLine());
            int numberFentasy = int.Parse(Console.ReadLine());
            int numberHorror = int.Parse(Console.ReadLine());
            int numberRomantics = int.Parse(Console.ReadLine());

            double totalMoney = 0.8*(numberFentasy * 14.9 + numberHorror * 9.8 + numberRomantics * 4.3);    

            if (totalMoney>=targetMoney)
            {
                double remainingMoney = totalMoney - targetMoney;
                double bonusMoney = Math.Floor(0.1 * remainingMoney);
                double afterBonusMoney = remainingMoney - bonusMoney;
                double donationMoney = targetMoney + afterBonusMoney;
                Console.WriteLine($"{donationMoney:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {bonusMoney} leva.");
            }
            else
            {
                Console.WriteLine($"{(targetMoney-totalMoney):f2} money needed.");
            }
        }
    }
}

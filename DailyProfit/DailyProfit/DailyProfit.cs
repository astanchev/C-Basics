using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Въведете работни дни в месеца: ");
            int workingDays = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете изкарани пари на ден в USD: ");
            double moneyPerDay = double.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете курс на USD: ");
            double usd = double.Parse(Console.ReadLine());
            double moneyPerMonth = workingDays * moneyPerDay;
            double yearlyEarnings = (12 * moneyPerMonth + 2.5 * moneyPerMonth) * 0.75;
            double averageEarningsInLeva = (yearlyEarnings*usd) / 365;
            Console.WriteLine("Парите на ден в лева са: {0:f2}", averageEarningsInLeva);

        }
    }
}

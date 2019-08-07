using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GoingHome
{
    class GoingHome
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int gasForHoundredKM = int.Parse(Console.ReadLine());
            double priceGasForLt = double.Parse(Console.ReadLine());
            double earnedMoney = double.Parse(Console.ReadLine());

            double gasForDistance = distance * gasForHoundredKM / 100.0;
            double moneyForGas = gasForDistance * priceGasForLt;

            if (earnedMoney>=moneyForGas)
            {
                Console.WriteLine($"You can go home. {earnedMoney-moneyForGas:f2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {earnedMoney/5:f2} money.");
            }
        }
    }
}

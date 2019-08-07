using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Zad1
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouvenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double gas = 420.0 / 100 * 7.0;
            double moneyForGas = gas*1.85;
            double totalMoneyForFoodAndSouvenirs = 3 * (moneyForFood + moneyForSouvenirs);
            double totalMoneyForHotel = moneyForHotel * 0.9 + moneyForHotel * 0.85 + moneyForHotel * 0.8;

            double neededMoney = moneyForGas+totalMoneyForFoodAndSouvenirs+totalMoneyForHotel;
            Console.WriteLine($"Money needed: {neededMoney:f2}");
        }
    }
}

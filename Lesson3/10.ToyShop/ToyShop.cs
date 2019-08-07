using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            double totalPriceExcursion = double.Parse(Console.ReadLine());
            int numberPuzzels = int.Parse(Console.ReadLine());
            int numberSpeakingDoll = int.Parse(Console.ReadLine());
            int numberTeddyBears = int.Parse(Console.ReadLine());
            int numberMinions = int.Parse(Console.ReadLine());
            int numberTrucks = int.Parse(Console.ReadLine());

            double pricePuzzels = 2.6*numberPuzzels;
            double priceSpeakingDoll = 3*numberSpeakingDoll;
            double priceTeddyBears = 4.1*numberTeddyBears;
            double priceMinions = 8.2*numberMinions;
            double priceTrucks = 2*numberTrucks;

            double priceToys = pricePuzzels + priceSpeakingDoll + priceTeddyBears + priceMinions + priceTrucks;
            int numbers = numberPuzzels + numberSpeakingDoll + numberTeddyBears + numberMinions + numberTrucks;

            if (numbers >= 50)
            {
                priceToys = priceToys * 0.75;
            }
            
            double totalPriceToys = priceToys*0.9;            

            if (totalPriceToys >= totalPriceExcursion)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", totalPriceToys - totalPriceExcursion);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", totalPriceExcursion - totalPriceToys);                               
            }
        }
    }
}

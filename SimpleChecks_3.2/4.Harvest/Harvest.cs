using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var vineyardArea = double.Parse(Console.ReadLine());
            var grapePerSquare = double.Parse(Console.ReadLine());
            var neededLiters = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var harvestPerVine = (0.4 * vineyardArea) * grapePerSquare;
            var wine = harvestPerVine / 2.5;
            

            if (wine >= neededLiters)
            {
                var wineLeft = wine - neededLiters;
                var litersPerWorker = wineLeft / workers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling(litersPerWorker)); 
            }
            else
            {
                var wineNeeded = neededLiters - wine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineNeeded));
            }



        }
    }
}

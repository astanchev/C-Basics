using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad4
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int foodInGrams = food * 1000;
            int eatedFood = 0;

            while (true)
            {
                string porcion = Console.ReadLine();
                if (porcion == "Adopted")
                {
                    break;
                }
                eatedFood += int.Parse(porcion);
            }


            if (eatedFood <= foodInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - eatedFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {eatedFood - foodInGrams} grams more.");
            }


        }
    }
}

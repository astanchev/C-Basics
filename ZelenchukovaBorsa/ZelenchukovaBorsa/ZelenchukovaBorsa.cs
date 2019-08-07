using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenchukovaBorsa
{
    class ZelenchukovaBorsa
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Въведете цена за килограм зеленчуци: ");
            double priceVegetables = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете цена за килограм плодове: ");
            double priceFruits = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете килограми зеленчуци: ");
            int weightVegetables = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете килограми плодове: ");
            int weightFruits = int.Parse(Console.ReadLine());
            double eur = 1.94;
            double profit = (priceFruits*weightFruits+priceVegetables*weightVegetables)/eur;

            Console.WriteLine("Печалбата е: {0}", profit);



        }
    }
}

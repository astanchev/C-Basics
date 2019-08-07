using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Christmas_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string decoration = string.Empty;
            int priceForDecoration = 0;
            
            while (true)
            {
                decoration = Console.ReadLine();
                if (decoration=="Stop")
                {
                    Console.WriteLine($"Money left: {budget}");
                    break;
                }
                for (int i = 0; i < decoration.Length; i++)
                {
                    priceForDecoration += decoration[i];
                }
                if (priceForDecoration<=budget)
                {
                    Console.WriteLine("Item successfully purchased!");
                    budget -= priceForDecoration;
                    priceForDecoration = 0;
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    break;
                }
            }




        }
    }
}

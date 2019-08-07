using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int adults = 0;
            int kids = 0;
            int moneyForToys = 0;
            int moneyForSweaters = 0;
            string age = string.Empty;
            int ageNumber = 0;

            while (true)
            {
                age = Console.ReadLine();
                if (age=="Christmas")
                {
                    break;
                }
                else
                {
                    ageNumber = int.Parse(age);
                }
                if (ageNumber>16)
                {
                    adults++;
                }
                else
                {
                    kids++;
                }
            }

            moneyForToys = kids * 5;
            moneyForSweaters = adults * 15;

            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");
        }
    }
}

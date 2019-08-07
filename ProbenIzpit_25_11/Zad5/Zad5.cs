using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Zad5
    {
        static void Main(string[] args)
        {
            int numberPassengers = int.Parse(Console.ReadLine());
            int numberBusStops = int.Parse(Console.ReadLine());            

            for (int i = 1; i <= numberBusStops; i++)
            {
                int passangersOut = int.Parse(Console.ReadLine());
                int passangersIn = int.Parse(Console.ReadLine());
                numberPassengers = numberPassengers + passangersIn - passangersOut;
                if (i%2==0)
                {
                    numberPassengers -= 2;
                }
                else
                {
                    numberPassengers += 2;
                }
            }

            Console.WriteLine($"The final number of passengers is : {numberPassengers}");
        }
    }
}

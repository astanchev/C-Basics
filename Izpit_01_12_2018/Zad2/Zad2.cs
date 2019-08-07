using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Zad2
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double distancetimeFor1m = double.Parse(Console.ReadLine());

            double timeGeorgi = distance * distancetimeFor1m;
            double delay = Math.Floor(distance / 50) * 30;
            double totalTime = timeGeorgi + delay;

            if (totalTime<record)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime-record:f2} seconds slower.");
            }


        }
    }
}

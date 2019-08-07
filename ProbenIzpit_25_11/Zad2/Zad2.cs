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
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());
            double astronautHigh = double.Parse(Console.ReadLine());

            double spaceshipVolume = width * lenght * high;
            double roomVolume = (astronautHigh + 0.40) * 2 * 2;

            double astronauts = Math.Floor(spaceshipVolume / roomVolume);

            if (astronauts>=3 && astronauts<=10)
            {
                Console.WriteLine($"The spacecraft holds {astronauts} astronauts.");
            }
            else if (astronauts < 3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            else if (astronauts > 10)
            {
                Console.WriteLine($"The spacecraft is too big.");
            }


        }
    }
}

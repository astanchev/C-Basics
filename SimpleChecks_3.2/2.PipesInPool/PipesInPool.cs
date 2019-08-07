using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PipesInPool
{
    class PipesInPool
    {
        static void Main(string[] args)
        {

            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double water = (pipe1 + pipe2) * hours;

            if (water<=volume)
            {
                double percentVolume = (water / volume) * 100;
                double percentPipe1 = ((pipe1*hours) / water) * 100;
                double percentPipe2 = ((pipe2*hours) / water) * 100;

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(percentVolume), Math.Truncate(percentPipe1), Math.Truncate(percentPipe2));

            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {(water-volume)} liters.");
            }





        }
    }
}

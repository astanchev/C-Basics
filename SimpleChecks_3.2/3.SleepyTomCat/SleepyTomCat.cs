using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int workingDays = 365 - holidays;
            int playMinutes = (holidays * 127) + (workingDays * 63);

            int difference = Math.Abs(playMinutes - 30000);
            int hours = difference / 60;
            int minutes = difference % 60;

            if (playMinutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }

        }
    }
}

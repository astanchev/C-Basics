using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hour++;
                minutes = minutes - 60;

                if (hour > 23)
                {
                    hour = 24 - hour;
                }

            }
            if (minutes < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, minutes);
            }



        }
    }
}

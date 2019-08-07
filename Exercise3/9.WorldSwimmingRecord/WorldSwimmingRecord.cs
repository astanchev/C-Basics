using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeForWholeSwim = distance * timeForOneMeter + (Math.Floor(distance / 15)) * 12.5;

            if (timeForWholeSwim < worldRecord)
                Console.WriteLine(" Yes, he succeeded! The new world record is {0:f2} seconds.", timeForWholeSwim);
            else
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", timeForWholeSwim-worldRecord);
        }
    }
}

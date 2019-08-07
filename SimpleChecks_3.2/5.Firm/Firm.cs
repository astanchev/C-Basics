using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Firm
{
    class Firm
    {
        static void Main(string[] args)
        {

            int neededHours = int.Parse(Console.ReadLine());
            int daysForWork = int.Parse(Console.ReadLine());
            int overTimeWorkers = int.Parse(Console.ReadLine());



            double availableDays = daysForWork * 0.9;
            double overTime = overTimeWorkers * 2 * availableDays;
            double hoursAllWorkers = Math.Floor(availableDays * 8 * overTimeWorkers + overTime);

            if (neededHours <= hoursAllWorkers)
            {
                double hoursLeft = hoursAllWorkers - neededHours;
                Console.WriteLine("Yes!{0} hours left.", hoursLeft);
            }
            else
            {
                double hoursNeeded = Math.Floor(neededHours - hoursAllWorkers);
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeeded);
            }


        }
    }
}

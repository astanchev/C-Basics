using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class ThreeBrothers
    {
        static void Main(string[] args)
        {
            double timeFirstBrother = double.Parse(Console.ReadLine());
            double timeSecondBrother = double.Parse(Console.ReadLine());
            double timeThirdBrother = double.Parse(Console.ReadLine());
            double timeFishingFather = double.Parse(Console.ReadLine());

            double totalTimeThreeBrothers = 1 / (1/timeFirstBrother+1/timeSecondBrother+1/timeThirdBrother);
            double cleaningTime = totalTimeThreeBrothers * 1.15;

            Console.WriteLine("Cleaning time: {0:f2}", cleaningTime);

            if (timeFishingFather >= cleaningTime)
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(timeFishingFather-cleaningTime));
            else
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(cleaningTime-timeFishingFather));
        }
    }
}

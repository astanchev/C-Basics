using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Choreography
{
    class Choreography
    {
        static void Main(string[] args)
        {
            int numberSteps = int.Parse(Console.ReadLine());
            int numberDancers = int.Parse(Console.ReadLine());
            int DaysForLearning = int.Parse(Console.ReadLine());

            double stepsPerDay = numberSteps / DaysForLearning;
            double percentStepsPerDay = Math.Ceiling(stepsPerDay / numberSteps * 100);            
            double percentStepsPerDancer = percentStepsPerDay / numberDancers;



            if (percentStepsPerDay<=13)
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", percentStepsPerDancer);
            else
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", percentStepsPerDancer);
        }
    }
}

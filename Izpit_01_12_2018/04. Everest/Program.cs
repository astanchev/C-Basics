using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 1;
            int sumMeters = 5364;
            while (true)
            {
                string sleep = Console.ReadLine();
                if (sleep == "END")
                {
                    break;
                }
                int meters = int.Parse(Console.ReadLine());
                if (days == 5 && sleep == "Yes")
                {
                    break;
                }
                sumMeters += meters;
                if (sleep == "Yes")
                {
                    days++;
                }
                if (sumMeters >= 8848)
                {
                    break;
                }
            }           

            if (sumMeters >= 8848)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine($"{sumMeters}");
            }
        }
    }
}

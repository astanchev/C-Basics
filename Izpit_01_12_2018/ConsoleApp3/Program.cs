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
            string sleep = Console.ReadLine();
            while (sleep != "END")
            {
                if (sleep == "Yes")
                {
                    days++;
                }
                int meters = int.Parse(Console.ReadLine());
                sumMeters += meters;                
                if (days > 4)
                {
                    Console.WriteLine($"Failed!");
                    Console.WriteLine($"{sumMeters}");
                    return;
                }
                if (sumMeters >= 8848)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    return;
                }
                sleep = Console.ReadLine();
            }            
                Console.WriteLine($"Failed!");
                Console.WriteLine($"{sumMeters}");
            
        }
    }
}

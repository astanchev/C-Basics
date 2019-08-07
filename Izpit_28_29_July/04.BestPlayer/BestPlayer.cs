using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BestPlayer
{
    class BestPlayer
    {
        static void Main(string[] args)
        {
            string bestPlayer = string.Empty;
            int goalsBestPlayer = 0;

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                int numberGoals = int.Parse(Console.ReadLine());
                if (numberGoals > goalsBestPlayer)
                {
                    goalsBestPlayer = numberGoals;
                    bestPlayer = name;
                }
                if (numberGoals >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (goalsBestPlayer >= 3)
            {
                Console.WriteLine($"He has scored {goalsBestPlayer} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalsBestPlayer} goals.");
            }
        }
    }
}

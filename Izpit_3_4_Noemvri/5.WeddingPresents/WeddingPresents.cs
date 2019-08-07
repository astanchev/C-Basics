using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WeddingPresents
{
    class WeddingPresents
    {
        static void Main(string[] args)
        {
            int numberGuests = int.Parse(Console.ReadLine());
            int numberPresents = int.Parse(Console.ReadLine());

            int counterA = 0;
            int counterB = 0;
            int counterV = 0;
            int counterG = 0;

            for (int i = 1; i <= numberPresents; i++)
            {
                string categoryPresent = Console.ReadLine().ToLower();
                switch (categoryPresent)
                {
                    case "a": counterA++; break;
                    case "b": counterB++; break;
                    case "v": counterV++; break;
                    case "g": counterG++; break;
                    default: break;
                }
            }
            int totalPresents = counterA + counterB + counterG + counterV;
            Console.WriteLine($"{counterA * 100.0 / numberPresents:f2}%");
            Console.WriteLine($"{counterB * 100.0 / numberPresents:f2}%");
            Console.WriteLine($"{counterV * 100.0 / numberPresents:f2}%");
            Console.WriteLine($"{counterG * 100.0 / numberPresents:f2}%");
            Console.WriteLine($"{totalPresents * 100.0 / numberGuests:f2}%");
        }
    }
}

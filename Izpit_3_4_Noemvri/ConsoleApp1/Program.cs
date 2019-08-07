using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int seatsOddRows = 3;
            for (char k = 'a'; k < ('a' + seatsOddRows + 2); k++)
            {
                Console.WriteLine($"{k}");
            }
        }
    }
}

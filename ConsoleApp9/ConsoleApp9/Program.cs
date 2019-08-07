using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            int sum = 100;
            if (int.TryParse(input, out number))
            {
                sum += number;
                Console.WriteLine($"{sum} \n{number}");
            }
            else
            {
                Console.WriteLine($"{sum} \n{number} \n{input}");
            }
        }
    }
}

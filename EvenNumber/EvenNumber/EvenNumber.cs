using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    class EvenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Числото "+number+" e четно!");
            }
            else
            {
                Console.WriteLine("Числото " + number + " e нечетно!");
            }
        }
    }
}

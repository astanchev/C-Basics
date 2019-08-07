using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber2
{
    class EvenNumber2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            bool even = (number % 2 == 0) ? true : false;
            Console.WriteLine("Число {0} е четно: {1}", number, even);
        }
    }
}

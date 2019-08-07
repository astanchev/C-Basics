using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class IsPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число 0<n<100 :");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (number > 2)
            {
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
                {
                    if (number % i == 0) isPrime = false;
                }
                Console.WriteLine("{0} is prime?: {1}", number, isPrime);
            }
            else
            {
                Console.WriteLine("1 is prime.");
            }
        }
    }
}

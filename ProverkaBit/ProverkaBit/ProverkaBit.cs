using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProverkaBit
{
    class ProverkaBit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            bool isOne = (((number >> 3) & 1) == 1) ? true : false;
            Console.WriteLine("Третия бит от дясно на ляво на числото {0} е 1: {1}", number, isOne);
        }
    }
}

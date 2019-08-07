using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProverkaCifra
{
    class ProverkaCifra
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            bool isSeven = ((number / 100) % 10 == 7) ? true : false;
            Console.WriteLine("Третата цифра от дясно на ляво на числото {0} е 7: {1}", number, isSeven);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Zad1
    {
        static void Main(string[] args)
        {
            int alpinists = int.Parse(Console.ReadLine());
            int carabineri = int.Parse(Console.ReadLine());
            int ropes = int.Parse(Console.ReadLine());
            int pikeli = int.Parse(Console.ReadLine());

            double sumCarabineri = carabineri * 36.0;
            double sumRopes = ropes * 3.6;
            double sumPikeli = pikeli * 19.80;
            double sumOneAlpinist = sumCarabineri + sumRopes + sumPikeli;
            double sumAllAlpinists = alpinists * sumOneAlpinist*1.2;

            Console.WriteLine($"{sumAllAlpinists:f2}");



        }
    }
}

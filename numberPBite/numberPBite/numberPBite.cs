using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPBite
{
    class numberPBite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете битова позиция: ");
            int p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;
            int positionP = ((n & mask) != 0) ? 1 : 0;
            Console.WriteLine("Бита на позиция {0} е {1}", p, positionP);
        }
    }
}

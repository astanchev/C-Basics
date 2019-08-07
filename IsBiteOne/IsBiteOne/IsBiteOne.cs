using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBiteOne
{
    class IsBiteOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете битова позиция: ");
            int p = int.Parse(Console.ReadLine());
            int mask = n >> p;
            bool positionP = ((mask&1) == 1) ? true : false;
            Console.WriteLine("Бита на позиция {0} е 1: {1}", p, positionP);
        }
    }
}

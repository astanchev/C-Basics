using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleneNa5
{
    class DeleneNa5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int delimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете число за делене: ");
            int delitel = int.Parse(Console.ReadLine());
            bool chastno = (delimo % delitel == 0) ? true : false;
            Console.WriteLine("Число {0} се дели на "+delitel+" {1}", delimo, chastno);
        }
    }
}

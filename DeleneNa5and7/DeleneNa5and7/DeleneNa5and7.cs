using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleneNa5and7
{
    class DeleneNa5and7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int delimo = int.Parse(Console.ReadLine());
            bool delitel1 = (delimo % 5) == 0;
            bool delitel2 = (delimo % 7) == 0;
            bool chastno = (delitel1 && delitel2) ? true : false;
            Console.WriteLine("Число {0} се дели на 5 и 7: {1}", delimo, chastno);
        }
    }
}

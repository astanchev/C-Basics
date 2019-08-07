using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbers3
{
    class EqualNumbers3
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == b && a == c)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}

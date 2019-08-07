using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueChange
{
    class ValueChange
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            Console.WriteLine(a + " " + b);
        }
    }
}

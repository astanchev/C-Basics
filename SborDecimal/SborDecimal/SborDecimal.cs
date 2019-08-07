using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SborDecimal
{
    class SborDecimal
    {
        static void Main(string[] args)
        {
            decimal number1 = 5.698345926m;
            decimal number2 = 9.87598631485m;
            number1 += number2;
            Console.WriteLine(number1.ToString("#.######"));
        }
    }
}

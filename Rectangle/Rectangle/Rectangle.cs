using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първа основа: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Въведете втора основа: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на правоъгълника е: {0}, периметъра е: {1}", a*b,(a + b) * 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapec
{
    class Trapec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете първа основа: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Въведете втора основа: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Въведете височина: ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на трапеца е: {0}", ((a+b)/2)*h);
        }
    }
}

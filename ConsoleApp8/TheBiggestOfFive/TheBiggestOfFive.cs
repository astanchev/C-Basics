using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine(a);
        }
    }
}

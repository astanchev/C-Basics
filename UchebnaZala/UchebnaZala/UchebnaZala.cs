using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UchebnaZala
{
    class UchebnaZala
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете дължина: ");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете ширина: ");
            double w = double.Parse(Console.ReadLine());
            double column = Math.Truncate((Math.Min(w, l) - 1) / 0.7);
            double row = Math.Truncate (Math.Max(w, l) / 1.2);
            Console.WriteLine("Работните места в залата са: {0}", (row*column - 3));
        }
    }
}

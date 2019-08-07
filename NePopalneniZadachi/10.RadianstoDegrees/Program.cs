using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double gradus = 180.0*radian/ Math.PI;
            Console.WriteLine(Math.Round(gradus));
        }
    }
}

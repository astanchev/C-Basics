using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotInCircle
{
    class DotInCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете координата x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете координата y: ");
            int y = int.Parse(Console.ReadLine());
            bool isInCircle = ((x * x + y * y) <= 25) ? true : false;
            Console.WriteLine("Точката О с координати x = {0} и y = {1} е в окръжността К((0,0), R=5): {2}", x, y, isInCircle);
        }
    }
}

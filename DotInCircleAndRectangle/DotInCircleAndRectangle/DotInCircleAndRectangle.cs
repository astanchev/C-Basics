using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotInCircleAndRectangle
{
    class DotInCircleAndRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете координата x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете координата y: ");
            int y = int.Parse(Console.ReadLine());
            bool isInCircle = ((x * x + y * y) <= 25) ? true : false;
            bool isOutsideRectangle = ((x<-1 || x>5) && (y<1 || y>5)) ? true : false;
            bool isBoth = isInCircle && isOutsideRectangle;
            Console.WriteLine("Точката О с координати x = {0} и y = {1} е в окръжността К((0,0), R=5) и извън правоъгълник ((-1,1)и(5,5)): {2}", x, y, isBoth);
        }
    }
}

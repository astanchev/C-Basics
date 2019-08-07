using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine($"Square = {area}");
        }
    }
}

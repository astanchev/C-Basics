using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = Math.Round((a*h / 2.0), 2);
            Console.WriteLine($"Triangle area = {area}");
        }
    }
}

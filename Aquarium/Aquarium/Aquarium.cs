using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Aquarium
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double totalVolumeLiters = length * width * height / 1000.0;
            double freeSpaceLiters = totalVolumeLiters * (100.0 - percent) / 100.0;
            Console.WriteLine($"{freeSpaceLiters:F3}");
        }
    }
}

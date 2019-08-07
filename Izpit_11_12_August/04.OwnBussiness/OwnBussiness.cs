using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OwnBussiness
{
    class OwnBussiness
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());

            int freeSpace = width * high * lenght;

            while (true)
            {
                string numberOfComputers = Console.ReadLine();
                if (numberOfComputers=="Done")
                {
                    Console.WriteLine($"{freeSpace} Cubic meters left.");
                    break;
                }
                int computers = int.Parse(numberOfComputers);
                freeSpace -= computers;
                if (freeSpace<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
            }

        }
    }
}

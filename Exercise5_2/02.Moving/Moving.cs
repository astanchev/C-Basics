using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());

            int freeSpace = width * lenght * high;
            int fullSpace = 0;

            while (true)
            {
                string boxes = Console.ReadLine();
                if (boxes=="Done")
                {
                    Console.WriteLine($"{freeSpace-fullSpace} Cubic meters left.");
                    break;
                }
                else
                {
                    fullSpace += int.Parse(boxes);
                    if (fullSpace>freeSpace)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(fullSpace-freeSpace)} Cubic meters more.");
                        break;
                    }
                }
            }

        }
    }
}

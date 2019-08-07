using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            bool printed = false;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == key && a < b && b < c)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {key}");
                            printed = true;
                        }
                        else if (a * b * c == key && a > b && b > c)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {key}");
                            printed = true;
                        }                        
                    }
                }
            }
            if (!printed)
            {
                Console.WriteLine("No!");
            }
        }
    }
}

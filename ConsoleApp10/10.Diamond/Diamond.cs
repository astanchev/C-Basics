using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (int)Math.Floor((n - 1) / 2f);
            int mid = 1;
            for (int i = 0; i < (int)Math.Floor((n / 2f) + 1); i++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
                if (leftRight < 0)
                {
                    leftRight = 0;
                    break;
                }

            }
            for (int i = 0; i < (int)Math.Floor((n - 1) / 2f); i++)
            {
                leftRight++;
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
            }
        }
    }
}

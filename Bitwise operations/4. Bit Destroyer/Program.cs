using System;

namespace _4._Bit_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int mask = ~(1 << p);

            number = number & mask;

            Console.WriteLine(number);
        }
    }
}

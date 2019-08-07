using System;

namespace _6._Tri_bit_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 7 << position;

            number = number ^ mask;

            Console.WriteLine(number);
        }
    }
}

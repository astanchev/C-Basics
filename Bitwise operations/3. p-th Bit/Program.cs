using System;

namespace _3._p_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            number = number >> p;
            Console.WriteLine(number & 1);
        }
    }
}

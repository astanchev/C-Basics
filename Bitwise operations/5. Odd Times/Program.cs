using System;
using System.Linq;

namespace _5._Odd_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result = result ^ arr[i];
            }
            Console.WriteLine(result);
        }
    }
}

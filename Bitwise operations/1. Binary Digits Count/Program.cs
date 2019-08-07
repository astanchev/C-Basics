using System;

namespace _1._Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            int count = 0;
            string numberToBits = Convert.ToString(n, 2);
            for (int i = 0; i < numberToBits.Length; i++)
            {
                if (numberToBits[i]==b)
                {                    
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

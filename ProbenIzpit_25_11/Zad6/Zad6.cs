using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad6
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            int firstNumber = number % 10;
            number = number / 10;
            int secondNumber = number % 10;
            number = number / 10;
            int thirdNumber = number % 10;

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    for (int k = 1; k <= thirdNumber; k++)
                    {
                        result = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }
                }
            }
        }
    }
}

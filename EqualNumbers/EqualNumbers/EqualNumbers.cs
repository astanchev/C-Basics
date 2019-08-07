using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbers
{
    class EqualNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първото число: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Въведете второто число: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine();
            bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;
            if (equal==true)
            {
                Console.WriteLine("Числата са равни!");
            }
            else
            {
                Console.WriteLine("Числата са различни!");
            }
        }
    }
}

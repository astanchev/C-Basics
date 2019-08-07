using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Project_Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double moneyForPoint = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    points *= 2;
                }
                totalPrice += points * moneyForPoint;
            }
            Console.WriteLine($"The project prize was {totalPrice:f2} lv.");
        }
    }
}

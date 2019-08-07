using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0.0;
            double taxiRate = 0.0;

            if (dayOrNight == "day")
            {
                taxiRate = 0.79; 
            }
            else
            {
                taxiRate = 0.90;
            }

            if (distance < 20)
            {
                price = 0.70 + distance * taxiRate;
            }
            else if (distance < 100)
            {
                price = distance * 0.09;
            }
            else
            {
                price = distance * 0.06;         
            }

            Console.WriteLine(price);

        }
    }
}

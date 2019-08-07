using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.WeddingHall
{
    class WeddingHall
    {
        static void Main(string[] args)
        {
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double barSide = double.Parse(Console.ReadLine());

            double hall = hallLenght * hallWidth;
            double bar = barSide * barSide;
            double dancing = hall * 0.19;
            double freespace = hall - bar - dancing;
            int numberGuests = (int)Math.Ceiling(freespace / 3.2);

            Console.WriteLine(numberGuests);
        }
    }
}

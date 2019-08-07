using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roofLenght = (int)Math.Ceiling(n / 2f);
            int houseLenght = (int)Math.Floor(n / 2f);
            int stars = 1;
            int padding = 1;
            if (n % 2 == 0)
            {
                stars++;
            }
            for (int i = 1; i <= roofLenght; i++)
            {        
                padding = (n - stars) / 2;
                string line = new string('-', padding) + new string('*', stars) + new string('-', padding);
                Console.WriteLine(line);
                stars += 2;
            }
            for (int i = 0; i < houseLenght; i++)
            {
                string line = "|" + new string('*', n - 2) + "|";
                Console.WriteLine(line);
            }
        }
    }
}

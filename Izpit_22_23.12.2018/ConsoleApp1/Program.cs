using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceForDecoration = 0;
            string decoration = Console.ReadLine();
            for (int i = 0; i < decoration.Length; i++)
            {
                priceForDecoration += decoration[i];
            }
            Console.WriteLine(priceForDecoration);
        }
    }
}

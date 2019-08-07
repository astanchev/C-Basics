using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Coins
{
    class Coins
    {
        static void Main(string[] args)
        {
            double suma = double.Parse(Console.ReadLine());
            suma *= 100;
            int countCoins = 0;

            while (suma>=200)
            {
                suma -= 200;
                countCoins++;
            }
            while (suma >= 100)
            {
                suma -= 100;
                countCoins++;
            }
            while (suma >= 50)
            {
                suma -= 50;
                countCoins++;
            }
            while (suma >= 20)
            {
                suma -= 20;
                countCoins++;
            }
            while (suma >= 10)
            {
                suma -= 10;
                countCoins++;
            }
            while (suma >= 5)
            {
                suma -= 5;
                countCoins++;
            }
            while (suma >= 2)
            {
                suma -= 2;
                countCoins++;
            }
            while (suma >= 1)
            {
                suma -= 1;
                countCoins++;
            }
            Console.WriteLine(countCoins);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int wholeCake = cakeLenght * cakeWidth;
            int eatenPieces = 0;

            while (true)
            {
                string pieces = Console.ReadLine();
                if (pieces == "STOP")
                {
                    Console.WriteLine($"{wholeCake - eatenPieces} pieces are left.");
                    break;
                }
                else
                {
                    eatenPieces += int.Parse(pieces);
                }
                if (eatenPieces >= wholeCake)
                {
                    Console.WriteLine($"No more cake left! You need {eatenPieces - wholeCake} pieces more.");
                    break;
                }
            }

        }
    }
}

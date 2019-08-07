using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.WeddingSeats
{
    class WeddingSeats
    {
        static void Main(string[] args)
        {
            string lastSector = Console.ReadLine();
            int numberRows = int.Parse(Console.ReadLine());
            int seatsOddRows = int.Parse(Console.ReadLine());
            int counterSeats = 0;

            for (char i = 'A'; i <= char.Parse(lastSector); i++)
            {                
                for (int j = 1; j <= numberRows; j++)
                {                   
                    if (j % 2 == 0)
                    {
                        for (char k = 'a'; k <= ('a' + seatsOddRows + 1); k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            counterSeats++;
                        }
                    }
                    else
                    {
                        for (char l = 'a'; l <= ('a' + seatsOddRows - 1); l++)
                        {
                            Console.WriteLine($"{i}{j}{l}");
                            counterSeats++;
                        }                    
                    }
                }
                numberRows++;
            }
            Console.WriteLine(counterSeats);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TicketCombination
{
    class TicketCombination
    {
        static void Main(string[] args)
        {
            int combinationNumber = int.Parse(Console.ReadLine());
            int counterCombinations = 0;
            int prize = 0;

            for (char stadium = 'B'; stadium <= 'L'; stadium++)
            {
                for (char sector = 'f'; sector >= 'a'; sector--)
                {
                    for (char entrance = 'A'; entrance <= 'C'; entrance++)
                    {
                        for (int row = 1; row <= 10; row++)
                        {
                            for (int seat = 10; seat >= 1; seat--)
                            {
                                if (stadium % 2 == 0)
                                {
                                    counterCombinations++;
                                }
                                if (counterCombinations == combinationNumber)
                                {
                                    Console.WriteLine($"Ticket combination: {stadium}{sector}{entrance}{row}{seat}");
                                    prize = stadium + sector + entrance + row + seat;
                                    Console.WriteLine($"Prize: {prize} lv.");
                                    break;
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}

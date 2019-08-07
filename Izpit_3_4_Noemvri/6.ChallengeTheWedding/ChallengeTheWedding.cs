using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ChallengeTheWedding
{
    class ChallengeTheWedding
    {
        static void Main(string[] args)
        {
            int numberMen = int.Parse(Console.ReadLine());
            int numberWomen = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int counterTakenTables = 0;

            for (int man = 1; man <= numberMen; man++)
            {
                for (int woman = 1; woman <= numberWomen; woman++)
                {
                    if (counterTakenTables == tables)
                    {
                        break;
                    }
                    Console.Write($"({man} <-> {woman}) ");
                    counterTakenTables++;                    
                }
            }
        }
    }
}

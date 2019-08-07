using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GameInfo
{
    class GameInfo
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());
            int countExtraTimeGames = 0;
            int countPenaltyGames = 0;
            double totalMinutes = 0.0;
            double averageMinutes = 0.0;


            for (int i = 1; i <= playedGames; i++)
            {
                double gameDuration = double.Parse(Console.ReadLine());
                if (gameDuration > 90 && gameDuration <= 120)
                {
                    countExtraTimeGames++;
                }
                else if (gameDuration > 120)
                {
                    countPenaltyGames++;
                }
                totalMinutes += gameDuration;
            }
            averageMinutes = totalMinutes / playedGames;
            Console.WriteLine($"{team} has played {totalMinutes} minutes. Average minutes per game: {averageMinutes:f2}");
            Console.WriteLine($"Games with penalties: {countPenaltyGames}");
            Console.WriteLine($"Games with additional time: {countExtraTimeGames}");
        }
    }
}

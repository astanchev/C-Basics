using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GroupStage
{
    class GroupStage
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int playedMaches = int.Parse(Console.ReadLine());
            int goalDifference = 0;
            int totalGoalDifference = 0;
            int points = 0;
            int totalPoints = 0;

            for (int i = 1; i <= playedMaches; i++)
            {
                int scoredGoals = int.Parse(Console.ReadLine());
                int receivedGoals = int.Parse(Console.ReadLine());
                goalDifference = scoredGoals - receivedGoals;
                totalGoalDifference += goalDifference;
                if (goalDifference > 0)
                {
                    points = 3;
                }
                else if (goalDifference == 0)
                {
                    points = 1;
                }
                else
                {
                    points = 0;
                }
                totalPoints += points;
            }
            if (totalGoalDifference >= 0)
            {
                Console.WriteLine($"{team} has finished the group phase with {totalPoints} points.");
                Console.WriteLine($"Goal difference: {totalGoalDifference}.");
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalGoalDifference}.");
            }
        }
    }
}

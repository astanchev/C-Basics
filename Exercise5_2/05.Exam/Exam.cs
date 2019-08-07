using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Exam
{
    class Exam
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            string lastProblem = string.Empty;
            int numberProblems = 0;
            int counterBadGrades = 0;
            double sumGrades = 0.0;
            double averageScore = 0.0;

            while (true)
            {
                string nameProblem = Console.ReadLine();               

                if (nameProblem == "Enough")
                {
                    Console.WriteLine($"Average score: {averageScore:f2}");
                    Console.WriteLine($"Number of problems: {numberProblems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }

                double grade = double.Parse(Console.ReadLine());
                numberProblems++;
                sumGrades += grade;
                averageScore = sumGrades / numberProblems;
                lastProblem = nameProblem;

                if (grade <= 4)
                {
                    counterBadGrades++;
                    if (counterBadGrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
                        break;
                    }
                }

            }
        }
    }
}

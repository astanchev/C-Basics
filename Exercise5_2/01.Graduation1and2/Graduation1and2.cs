using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Graduation1and2
{
    class Graduation1and2
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clas = 1;
            int badGrades = 0;
            
            double totalGrades = 0.0;
            while (true)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade>=4)
                {
                    totalGrades += grade;
                    if (clas == 12)
                    {
                        Console.WriteLine($"{name} graduated. Average grade: {totalGrades / clas:f2}");
                        break;
                    }
                    clas++;
                }
                else
                {
                    badGrades++;
                    if (badGrades>1)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas} grade");
                        break;
                    }
                }
                
            }
        }
    }
}

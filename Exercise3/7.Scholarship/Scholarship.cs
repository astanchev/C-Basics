using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrades = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            
            double ammountSocialScolarship = Math.Floor(0.35 * minimalWage);
            double ammountGradesScolarship = Math.Floor(averageGrades * 25);

            if (averageGrades<4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (averageGrades >= 4.50 && averageGrades < 5.50 && income > minimalWage)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (averageGrades>=4.50 && averageGrades<5.50 && income <= minimalWage)
            {                
                Console.WriteLine("You get a Social scholarship {0} BGN", ammountSocialScolarship);
            }            
            else
            {
                if (income <= minimalWage)
                {                    
                    if (ammountGradesScolarship  >= ammountSocialScolarship)                    
                        Console.WriteLine("You get a scholarship for excellent results {0} BGN", ammountGradesScolarship);                    
                    else                    
                        Console.WriteLine("You get a Social scholarship {0} BGN", ammountSocialScolarship);                                            
                }
                else                    
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", ammountGradesScolarship);                
            }
        }
    }
}

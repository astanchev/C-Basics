using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Zad5
    {
        static void Main(string[] args)
        {
            int numberGroups = int.Parse(Console.ReadLine());
            int peopleInGroup = 0;
            int totalPeople = 0;
            int peopleMusala = 0;
            int peopleMonBlan = 0;
            int peopleKalimangaro = 0;
            int peopleK2 = 0;
            int peopleEverest = 0;



            for (int i = 1; i <= numberGroups; i++)
            {
                peopleInGroup = int.Parse(Console.ReadLine());
                if (peopleInGroup <= 5)
                {
                    peopleMusala += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    peopleMonBlan += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    peopleKalimangaro += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    peopleK2 += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
                else if (peopleInGroup >= 41)
                {
                    peopleEverest += peopleInGroup;
                    totalPeople += peopleInGroup;
                }
            }
            Console.WriteLine($"{peopleMusala*100.0/totalPeople:f2}%");
            Console.WriteLine($"{peopleMonBlan*100.0/totalPeople:f2}%");
            Console.WriteLine($"{peopleKalimangaro*100.0/totalPeople:f2}%");
            Console.WriteLine($"{peopleK2*100.0/totalPeople:f2}%");
            Console.WriteLine($"{peopleEverest*100.0/totalPeople:f2}%");



        }
    }
}

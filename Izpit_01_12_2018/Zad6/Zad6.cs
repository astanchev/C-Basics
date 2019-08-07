using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            int counterPasswords = 0;
            int i = 35;
            int j = 64;

            for (int k = 1; k <= a; k++)
            {
                for (int l = 1; l <= b; l++)
                {
                    char firstLetter = (char)i;
                    char secondLetter = (char)j;
                    char fifthLetter = (char)j;
                    char sixthLetter = (char)i;
                    Console.Write($"{firstLetter}{secondLetter}{k}{l}{fifthLetter}{sixthLetter}|");
                    counterPasswords++;
                    if (k == a && l == b || counterPasswords == maxPasswords)
                    {
                        return;
                    }
                    i++;
                    j++;
                    if (i > 55)
                    {
                        i = 35;
                    }
                    if (j > 96)
                    {
                        j = 64;
                    }
                }
            }

        }
    }
}

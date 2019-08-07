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
            int i = 0;
            int j = 0;

            while (true)
            {

                for (int k = 1; k <= a; k++)
                {
                    for (int l = 1; l <= b; l++)
                    {

                        char firstLetter = (char)(35 + i);
                        char secondLetter = (char)(64 + j);
                        char fifthLetter = (char)(64 + j);
                        char sixthLetter = (char)(35 + i);
                        Console.Write($"{firstLetter}{secondLetter}{k}{l}{fifthLetter}{sixthLetter}|");
                        counterPasswords++;
                        if (k == a && l == b || counterPasswords == maxPasswords)
                        {
                            return;
                        }
                        i++;
                        j++;
                        if (i > 21)
                        {
                            i = 0;
                        }
                        if (j > 23)
                        {
                            j = 0;
                        }
                    }
                }
            }
        }
    }
}

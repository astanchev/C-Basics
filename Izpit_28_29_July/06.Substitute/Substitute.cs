using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Substitute
{
    class Substitute
    {
        static void Main(string[] args)
        {
            int firstDigitFirstNumberStart = int.Parse(Console.ReadLine());
            int secondDigitFirstNumberEnd = int.Parse(Console.ReadLine());
            int firstDigitSecondNumberStart = int.Parse(Console.ReadLine());
            int secondDigitSecondNumberEnd = int.Parse(Console.ReadLine());

            int counterChanges = 0;

            for (int k = firstDigitFirstNumberStart; k <= 8 ; k++)
            {
                if (k % 2 == 0)
                {
                    for (int l = 9; l >= secondDigitFirstNumberEnd; l--)
                    {
                        if (l % 2 != 0)
                        {
                            for (int m = firstDigitSecondNumberStart; m <= 8; m++)
                            {
                                if (m % 2 == 0)
                                {
                                    for (int n = 9; n >= secondDigitSecondNumberEnd; n--)
                                    {
                                        if (n % 2 != 0)
                                        {
                                            if (counterChanges == 6)
                                            {
                                                break;
                                            }
                                            if (k == m && l == n)
                                            {
                                                Console.WriteLine("Cannot change the same player.");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{k}{l} - {m}{n}");
                                                counterChanges++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

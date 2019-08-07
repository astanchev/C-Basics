using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UniquePINCodes
{
    class UniquePINCodes
    {
        static void Main(string[] args)
        {
            int firstNumberCeiling = int.Parse(Console.ReadLine());
            int secondNumberCeiling = int.Parse(Console.ReadLine());
            int thirdNumberCeiling = int.Parse(Console.ReadLine());

            for (int i = 2; i <= firstNumberCeiling; i+=2)
            {
                for (int j = 1; j <= secondNumberCeiling; j++)
                {
                    for (int k = 2; k <= thirdNumberCeiling; k+=2)
                    {
                        if (j==2||j==3||j==5||j==7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }

        }
    }
}

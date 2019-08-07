using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nfactoriel
{
    class Nfactoriel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            decimal sum = 1;

            while (i<=n)
            {
                sum = sum*i;
                i++;
            }
            Console.WriteLine(sum);



        }
    }
}

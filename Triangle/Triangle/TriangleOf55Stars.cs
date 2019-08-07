using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            char cMark = '*';//'\u00A9';
            //Console.WriteLine("Въведете брой редове: ");
            int n = 10;//int.Parse (Console.ReadLine());
            for (int i = 1; i<=n; i++)
            Console.WriteLine(new string(cMark, i));           
        }
    }
}

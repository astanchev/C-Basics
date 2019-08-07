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
            char cMark = '\u00A9';
            string baseTriangle = new string (cMark,9);
            Console.WriteLine("    "+cMark);
            Console.WriteLine("   "+cMark+" "+cMark);
            Console.WriteLine("  "+cMark+"   "+cMark);
            Console.WriteLine(" "+cMark+"     "+cMark);
            Console.WriteLine(cMark.ToString()+ cMark.ToString()+ cMark.ToString()+ cMark.ToString()+ cMark.ToString()+ cMark.ToString()+ cMark.ToString()+ cMark.ToString()+ cMark.ToString()+ cMark.ToString());
            Console.WriteLine();
            char cMark2 = 'o';
            Console.WriteLine(cMark2.ToString() + cMark2.ToString());
        }
    }
}

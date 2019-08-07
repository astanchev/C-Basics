using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowNumbers
{
    class RowNumbers
    {
        static void Main(string[] args)
        {
            for (var i = 2; i < 102; i+=1)
            {
                if (i % 2 == 0) Console.Write(" {0}", i);
                else Console.Write(" -{0}", i);
            }
            Console.WriteLine();
        }
    }
}

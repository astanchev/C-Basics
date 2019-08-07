using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromianaBitePosition
{
    class PromianaBitePosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете битова позиция: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете битова цифра 0 или 1: ");
            int v = int.Parse(Console.ReadLine());
            n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
            Console.WriteLine("Новото число след промяна на бита е: "+n);
        }
    }
}

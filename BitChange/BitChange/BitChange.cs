using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitChange
{
    class BitChange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число: ");
            int num = int.Parse(Console.ReadLine());
            int bit3 = (num >> 3) & 1; //Ако третия бит е едно връща 1, ако не 0
            int bit24 = (num >> 24) & 1; //Ако двадест и четвъртия бит е едно връща 1, ако не 0
            num = (num & (~(1 << 24))) | (bit3 << 24); //Първата част & нулира 24-я бит, а втората | присвоява стойността на 3-я бит на 24-я
            num = (num & (~(1 << 3))) | (bit24 << 3); //Първата част & нулира 3-я бит, а втората | присвоява стойността на 24-я бит на 3-я
            int bit4 = (num >> 4) & 1;
            int bit25 = (num >> 25) & 1;
            num = (num & (~(1 << 25))) | (bit4 << 25);
            num = (num & (~(1 << 4))) | (bit25 << 4);
            int bit5 = (num >> 5) & 1;
            int bit26 = (num >> 26) & 1;
            num = (num & (~(1 << 26))) | (bit5 << 26);
            num = (num & (~(1 << 5))) | (bit26 << 5);
            Console.WriteLine("Новото число е: {0}", num);
        }
    }
}

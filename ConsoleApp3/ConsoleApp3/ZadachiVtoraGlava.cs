using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachiVtoraGlava
{
    class ZadachiVtoraGlava
    {
        static void Main(string[] args)
        {
            char proba = '\u0048';
            Console.WriteLine(proba);
            bool isMale = true;
            Console.WriteLine(isMale);
            string pozdrav = "Hello";
            string ime = "World";
            object pozdravIme = pozdrav + " " + ime + "!";
            Console.WriteLine(pozdravIme);
            string newPozdravIme;
            newPozdravIme = pozdravIme.ToString();
            Console.WriteLine(newPozdravIme);
            string str1 = "The \"use\" of quotations causes difficulties.";
            string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties.";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}

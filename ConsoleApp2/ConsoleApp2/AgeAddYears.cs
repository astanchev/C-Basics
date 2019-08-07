using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAddYears
{
    class AgeAddYears
    {
        static void Main(string[] args)
        {
            Console.Write("На колко години сте? ");
            int age = int.Parse(Console.ReadLine());
            DateTime sys_time = DateTime.Now;
            Console.WriteLine("Вие сте на {0} години, а текущото време е {1}.", age, sys_time);
            Console.WriteLine("След 10 години ще сте на {0} години, а текущото време ще е {1}.", age + 10, sys_time.AddYears(10));
        }
    }
}

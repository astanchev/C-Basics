using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете четирицифрено число: ");
            int number = int.Parse(Console.ReadLine());
            if (number>999 && number < 10000)
            {
                int d = (number % 10);
                int c = ((number/10)%10);
                int b = ((number / 100) % 10);
                int a = ((number / 1000) % 10);
                Console.WriteLine("Сбора на цифрите е: {0}", (a+b+c+d));
                Console.WriteLine("Цифрите в обратен ред са: "+d+c+b+a);
                Console.WriteLine("Последната цифра в началото е: " + d + a + b + c);
                Console.WriteLine("Разменени втора и трета цифра: "+a+c+b+d);
            }
            else
            {
                Console.WriteLine("Въведеното число не е четирицифрено!");
            }
        }
    }
}

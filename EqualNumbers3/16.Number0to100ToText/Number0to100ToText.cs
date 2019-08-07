using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number0to100ToText
{
    class Number0to100ToText
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int desetici = 1;
            int edinici = 1;

            string tens = null;
            string ones = null;
            
            if (number < 10 && number >= 0)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;                    
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default: break;
                }
            }
            else if (number > 9  && number < 20)
            {
                switch (number)
                {
                    case 10: Console.WriteLine("ten");break;
                    case 11: Console.WriteLine("eleven");break;
                    case 12: Console.WriteLine("twelve");break;
                    case 13: Console.WriteLine("thirteen");break;
                    case 14: Console.WriteLine("fourteen");break;
                    case 15: Console.WriteLine("fifteen");break;
                    case 16: Console.WriteLine("sixteen");break;
                    case 17: Console.WriteLine("seventeen");break;
                    case 18: Console.WriteLine("eighteen");break;
                    case 19: Console.WriteLine("nineteen");break;
                    default: break;
                }
            }
            else if (number>19 && number<100)
            {
                desetici = number / 10;
                edinici = number % 10;

                switch (desetici)
                {
                    case 2: tens = "twenty"; break;
                    case 3: tens = "thirty"; break;
                    case 4: tens = "forty"; break;
                    case 5: tens = "fifty"; break;
                    case 6: tens = "sixty"; break;
                    case 7: tens = "seventy"; break;
                    case 8: tens = "eighty"; break;
                    case 9: tens = "ninety"; break;
                    default: break;
                }
                switch (edinici)
                {
                    case 0: ones = null; break;
                    case 1: ones = "one"; break;
                    case 2: ones = "two"; break;
                    case 3: ones = "three"; break;
                    case 4: ones = "four"; break;
                    case 5: ones = "five"; break;
                    case 6: ones = "six"; break;
                    case 7: ones = "seven"; break;
                    case 8: ones = "eight"; break;
                    case 9: ones = "nine"; break;
                    default: break;
                }

                if (ones == null)
                {
                    Console.WriteLine(tens);
                }
                else
                {
                    Console.WriteLine("{0} {1}", tens, ones);
                }

            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }


        }
    }
}

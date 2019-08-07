using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter variable type (0 - int, 1 - double, 2 string): ");
            int variableType = int.Parse(Console.ReadLine());

            switch (variableType)
            {
                case 0:
                    {
                        Console.Write("Enter int variable: ");
                        int intType = int.Parse(Console.ReadLine());
                        intType++;
                        Console.WriteLine("Int variable + 1 = {0}", intType);
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable: ");
                        double doubleType = double.Parse(Console.ReadLine());
                        doubleType = doubleType + 1.0;
                        Console.WriteLine("Double variable + 1 = {0}", doubleType);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string stringVariable = Console.ReadLine();
                        stringVariable = stringVariable + '*';
                        Console.WriteLine("String variable + * = {0}", stringVariable);
                        break;

                    }
                default: Console.WriteLine("Wrong input"); break;
            }




        }
    }
}

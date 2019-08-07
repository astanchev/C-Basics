using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double moneyForExcursion = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int countSpendDays = 0;
            int countTotalDays = 0;

            while (true)
            {
                string input = Console.ReadLine();
                double inputMoney = double.Parse(Console.ReadLine());
                countTotalDays++;

                if (input == "spend")
                {
                    countSpendDays++;
                    if (inputMoney > availableMoney)
                    {
                        availableMoney = 0;
                    }
                    else
                    {
                        availableMoney -= inputMoney;
                    }
                }

                else if (input == "save")
                {
                    countSpendDays = 0;
                    availableMoney += inputMoney;
                }

                if (countSpendDays == 5)
                {
                    Console.WriteLine("You can't save the money.\n{0}", countTotalDays);
                    break;
                }

                if (availableMoney >= moneyForExcursion)
                {
                    Console.WriteLine($"You saved the money for {countTotalDays} days.");
                    break;
                }

                
            }
        }
    }
}

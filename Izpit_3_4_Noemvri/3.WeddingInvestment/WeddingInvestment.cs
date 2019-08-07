using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WeddingInvestment
{
    class WeddingInvestment
    {
        static void Main(string[] args)
        {
            string contractLenght = Console.ReadLine();
            string contractType = Console.ReadLine();
            string desert = Console.ReadLine();
            int numberMonths = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;
            double monthlyPrice = 0.0;

            switch (contractType)
            {
                case "Small":
                    if (contractLenght == "one")
                    {
                        if (desert == "yes")
                        {
                            monthlyPrice = 9.98 + 5.5;
                        }
                        else if (desert == "no")
                        {
                            monthlyPrice = 9.98;
                        }
                        totalPrice = numberMonths * monthlyPrice;
                    }
                    else if (contractLenght == "two")
                    {
                        if (desert == "yes")
                        {
                            monthlyPrice = 8.58 + 5.5;
                        }
                        else if (desert == "no")
                        {
                            monthlyPrice = 8.58;
                        }
                        totalPrice = numberMonths * monthlyPrice - 3.75 * (numberMonths * monthlyPrice) / 100;
                    }
                    break;
                case "Middle":
                    if (contractLenght == "one")
                    {
                        if (desert == "yes")
                        {
                            monthlyPrice = 18.99 + 4.35;
                        }
                        else if (desert == "no")
                        {
                            monthlyPrice = 18.99;
                        }
                        totalPrice = numberMonths * monthlyPrice;
                    }
                    else if (contractLenght == "two")
                    {
                        if (desert == "yes")
                        {
                            monthlyPrice = 17.09 + 4.35;
                        }
                        else if (desert == "no")
                        {
                            monthlyPrice = 17.09;
                        }
                        totalPrice = numberMonths * monthlyPrice - 3.75 * (numberMonths * monthlyPrice) / 100;
                    }
                    break;
                case "Large":
                    if (contractLenght == "one")
                    {
                        if (desert == "yes")
                        {
                            monthlyPrice = 25.98 + 4.35;
                        }
                        else if (desert == "no")
                        {
                            monthlyPrice = 25.98;
                        }
                        totalPrice = numberMonths * monthlyPrice;
                    }
                    else if (contractLenght == "two")
                    {
                        if (desert == "yes")
                        {
                            monthlyPrice = 23.59 + 4.35;
                        }
                        else if (desert == "no")
                        {
                            monthlyPrice = 23.59;
                        }
                        totalPrice = numberMonths * monthlyPrice - 3.75 * (numberMonths * monthlyPrice) / 100;
                    }
                    break;
                case "ExtraLarge":
                    if (contractLenght == "one")
                    {
                        if (desert == "yes")
                        {
                            monthlyPrice = 35.99 + 3.85;
                        }
                        else if (desert == "no")
                        {
                            monthlyPrice = 35.99;
                        }
                        totalPrice = numberMonths * monthlyPrice;
                    }
                    else if (contractLenght == "two")
                    {
                        if (desert == "yes")
                        {
                            monthlyPrice = 31.79 + 3.85;
                        }
                        else if (desert == "no")
                        {
                            monthlyPrice = 31.79;
                        }
                        totalPrice = numberMonths * monthlyPrice - 3.75 * (numberMonths * monthlyPrice) / 100;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}

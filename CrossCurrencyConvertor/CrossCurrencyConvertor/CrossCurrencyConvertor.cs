using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCurrencyConvertor
{
    class CrossCurrencyConvertor
    {
        static void Main(string[] args)
        {
            double bgn = 1;
            double eur = bgn/1.95583;
            double usd = bgn/1.79549;
            double gbp = bgn/2.53405;
            double amount;
            string inputCurrency, outputCurrency;
            Console.WriteLine("Въведете сума за конвертиране: ");
            amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете входна валута (EUR, BGN, USD, GBP): ");
            inputCurrency = Console.ReadLine().ToLower();
            Console.WriteLine("Въведете изходна валута (EUR, BGN, USD, GBP): ");
            outputCurrency = Console.ReadLine().ToLower();
            if (inputCurrency == "bgn")
                if (outputCurrency == "eur")
                    Console.WriteLine("Конвертираната валута е: " + (amount * eur));
                else if (outputCurrency == "usd")
                    Console.WriteLine("Конвертираната валута е: " + (amount * usd));
                else if (outputCurrency == "gbp")
                    Console.WriteLine("Конвертираната валута е: " + (amount * gbp));
            if (inputCurrency == "eur")
                if (outputCurrency == "bgn")
                    Console.WriteLine("Конвертираната валута е: " + (amount *(1/eur)));
                else if (outputCurrency == "usd")
                    Console.WriteLine("Конвертираната валута е: " + (amount * (usd/eur)));
                else if (outputCurrency == "gbp")
                    Console.WriteLine("Конвертираната валута е: " + (amount * (gbp/eur)));
            if (inputCurrency == "usd")
                if (outputCurrency == "bgn")
                    Console.WriteLine("Конвертираната валута е: " + (amount * (1 / usd)));
                else if (outputCurrency == "eur")
                    Console.WriteLine("Конвертираната валута е: " + (amount * (eur/usd)));
                else if (outputCurrency == "gbp")
                    Console.WriteLine("Конвертираната валута е: " + (amount * (gbp/usd)));
            if (inputCurrency == "gbp")
                if (outputCurrency == "bgn")
                    Console.WriteLine("Конвертираната валута е: " + (amount *(1/gbp)));
                else if (outputCurrency == "usd")
                    Console.WriteLine("Конвертираната валута е: " + (amount * (usd/gbp)));
                else if (outputCurrency == "eur")
                    Console.WriteLine("Конвертираната валута е: " + (amount * (eur/gbp)));










        }
    }
}

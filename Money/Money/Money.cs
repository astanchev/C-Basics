using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int lev = 1;
            int bitcoin = 1168 * lev;
            double usd = 1.76 * lev;
            double eur = 1.95 * lev;
            double chYuan = 0.15 * usd;

            //Console.WriteLine("Въведете количество биткойни за обмяна: ");
            int ammountBitcoins = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете количество китайски юани за обмяна: ");
            double ammountChineseYuans = double.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете комисионна за обмяната (0% до 5%): ");
            double commission = (double.Parse(Console.ReadLine()))/100;
            double bitcoinsInEuro = (ammountBitcoins * bitcoin) / eur;
            double chYuansInEuro = (ammountChineseYuans * chYuan) / eur;
            double result = (bitcoinsInEuro + chYuansInEuro) - (bitcoinsInEuro + chYuansInEuro) * commission;
            Console.WriteLine(/*"Крайният резултат е: {0}", */result);
        }
    }
}

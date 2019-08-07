using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProba
{
    class ForexExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете количество валута:");
            var ammountForex = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете вид входяща валута (usd, eur, gbp, bgn):");
            var inputForex = Console.ReadLine();
            Console.WriteLine("Въведете вид изходяща валута (usd, eur, gbp, bgn):");
            var outputForex = Console.ReadLine();

            var forex = new Dictionary<string, double>()
            {
                {"usd", 1.70},
                {"eur", 1.95},
                {"gbp", 2.53},
                {"bgn", 1}
            };

            var outputAmmount = ammountForex * forex[inputForex] / forex[outputForex];
            Console.WriteLine();
            Console.WriteLine(Math.Round(outputAmmount, 2)+" "+outputForex);
        }
    }
}

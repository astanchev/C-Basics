using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Proba
{
    class Add1000Days
    {
        static void Main(string[] args)
        {
            string dateString;
            string format = "dd-MM-yyyy";
            DateTime result;
            CultureInfo provider = CultureInfo.InvariantCulture;
            //Console.WriteLine("Въведете рождена дата във формат dd-MM-yyyy ");
            dateString = Console.ReadLine();
            result = DateTime.ParseExact(dateString, format, provider);
            DateTime result1000 = result.AddDays(1000);
            Console.WriteLine(/*"След 1000 дни ще бъде {0} ",*/ result1000.ToString(format));
        }
    }
}

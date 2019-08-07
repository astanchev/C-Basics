using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsYourName
{
    class WhatsYourName
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            System.Console.WriteLine("Как е първото Ви име?");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Как е фамилията Ви?");
            LastName = System.Console.ReadLine();
            System.Console.WriteLine("Здравей {0}. Фамилията ти е {1}",FirstName, LastName);
        }
    }
}

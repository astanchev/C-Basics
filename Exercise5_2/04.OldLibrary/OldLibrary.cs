using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OldLibrary
{
    class OldLibrary
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int lookedBookNumber = 0;

            while (true)
            {
                string newBookName = Console.ReadLine();
                
                if (newBookName == bookName)
                {
                    Console.WriteLine($"You checked {lookedBookNumber} books and found it.");
                    break;
                }
                lookedBookNumber++;
                if (lookedBookNumber == capacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {lookedBookNumber} books.");
                    break;
                }
            }
        }
    }
}

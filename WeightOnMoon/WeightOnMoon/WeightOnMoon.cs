using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightOnMoon
{
    class WeightOnMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете тежест: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            double weightOnMoon = weight * 0.17;
            Console.WriteLine("Тежестта на Луната е: "+weightOnMoon);
        }
    }
}

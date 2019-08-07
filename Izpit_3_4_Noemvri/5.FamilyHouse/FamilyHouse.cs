using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FamilyHouse
{
    class FamilyHouse
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricity = 0.0;
            double water = 20.0;
            double internet = 15.0;
            double other = 0.0;
            double average = 0.0;
            double electricitySum = 0.0;
            double waterSum = 0.0;
            double internetSum = 0.0;
            double otherSum = 0.0;

            for (int i = 1; i <= months; i++)
            {
                electricity = double.Parse(Console.ReadLine());
                other = 1.2 * (electricity + water + internet);
                electricitySum += electricity;
                otherSum += other;
            }
            waterSum = months * water;
            internetSum = months * internet;
            average = (electricitySum + waterSum + internetSum + otherSum) / months;

            Console.WriteLine($"Electricity: {electricitySum:f2} lv");
            Console.WriteLine($"Water: {waterSum:f2} lv");
            Console.WriteLine($"Internet: {internetSum:f2} lv");
            Console.WriteLine($"Other: {otherSum:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}

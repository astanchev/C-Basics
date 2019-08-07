using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.School_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAbsence = int.Parse(Console.ReadLine());
            int leftFoodInKilos = int.Parse(Console.ReadLine());
            double foodFirstDog1day = double.Parse(Console.ReadLine());
            double foodSecondDog1day = double.Parse(Console.ReadLine());
            double foodThirdDog1day = double.Parse(Console.ReadLine());

            double firstDogTotal = daysOfAbsence * foodFirstDog1day;
            double secondDogTotal = daysOfAbsence * foodSecondDog1day;
            double thirdDogTotal = daysOfAbsence * foodThirdDog1day;

            double totalFood = firstDogTotal + secondDogTotal + thirdDogTotal;

            if (leftFoodInKilos>=totalFood)
            {
                Console.WriteLine($"{Math.Floor(leftFoodInKilos-totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood-leftFoodInKilos)} more kilos of food are needed.");
            }

        }
    }
}

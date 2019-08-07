using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            
            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            double outputNumber = 0;

            switch (inputMetric.ToLower())
            {
                case "m":
                    switch (outputMetric.ToLower())
                        {
                            case "mm":
                                outputNumber = number * mm;
                                break;
                            case "cm":
                                outputNumber = number * cm;
                                break;
                            case "mi":
                                outputNumber = number * mi;
                                break;
                            case "in":
                                outputNumber = number * inch;
                                break;
                            case "km":
                                outputNumber = number * km;
                                break;
                            case "ft":
                                outputNumber = number * ft;
                                break;
                            case "yd":
                                outputNumber = number * yd;
                                break;
                            case "m":
                                outputNumber = number;
                                break;
                            default: break;
                        }
                    break;
                    
                case "mm":
                    switch (outputMetric.ToLower())
                    {
                        case "m":
                            outputNumber = number/mm;
                            break;
                        case "cm":
                            outputNumber = (number/mm)*cm;
                            break;
                        case "mi":
                            outputNumber = (number / mm)*mi;
                            break;
                        case "in":
                            outputNumber = (number / mm)*inch;
                            break;
                        case "km":
                            outputNumber = (number / mm) *km;
                            break;
                        case "ft":
                            outputNumber = (number / mm) *ft;
                            break;
                        case "yd":
                            outputNumber = (number / mm) *yd;
                            break;
                        case "mm":
                            outputNumber = number;
                            break;
                        default: break;
                    }
                    break;

                case "cm":
                    switch (outputMetric.ToLower())
                    {
                        case "m":
                            outputNumber = number/cm;
                            break;
                        case "mm":
                            outputNumber = (number / cm) *mm;
                            break;
                        case "mi":
                            outputNumber = (number / cm) *mi;
                            break;
                        case "in":
                            outputNumber = (number / cm) *inch;
                            break;
                        case "km":
                            outputNumber = (number / cm) *km;
                            break;
                        case "ft":
                            outputNumber = (number / cm) *ft;
                            break;
                        case "yd":
                            outputNumber = (number / cm) *yd;
                            break;
                        case "cm":
                            outputNumber = number;
                            break;
                        default: break;
                    }
                    break;

                case "mi":
                    switch (outputMetric.ToLower())
                    {
                        case "m":
                            outputNumber = number/mi;
                            break;
                        case "cm":
                            outputNumber = (number / mi) *cm;
                            break;
                        case "mm":
                            outputNumber = (number / mi) *mm;
                            break;
                        case "in":
                            outputNumber = (number / mi) *inch;
                            break;
                        case "km":
                            outputNumber = (number / mi) *km;
                            break;
                        case "ft":
                            outputNumber = (number / mi) *ft;
                            break;
                        case "yd":
                            outputNumber = (number / mi) *yd;
                            break;
                        case "mi":
                            outputNumber = number;
                            break;
                        default: break;
                    }
                    break;

                case "in":
                    switch (outputMetric.ToLower())
                    {
                        case "m":
                            outputNumber = number/inch;
                            break;
                        case "cm":
                            outputNumber = (number / inch)*cm;
                            break;
                        case "mi":
                            outputNumber = (number / inch) *mi;
                            break;
                        case "mm":
                            outputNumber = (number / inch) *mm;
                            break;
                        case "km":
                            outputNumber = (number / inch) *km;
                            break;
                        case "ft":
                            outputNumber = (number / inch) *ft;
                            break;
                        case "yd":
                            outputNumber = (number / inch) *yd;
                            break;
                        case "in":
                            outputNumber = number;
                            break;
                        default: break;
                    }
                    break;

                case "km":
                    switch (outputMetric.ToLower())
                    {
                        case "m":
                            outputNumber = number / km;
                            break;
                        case "cm":
                            outputNumber = (number / km)*cm;
                            break;
                        case "mi":
                            outputNumber = (number / km) *mi;
                            break;
                        case "in":
                            outputNumber = (number / km) *inch;
                            break;
                        case "mm":
                            outputNumber = (number / km) *mm;
                            break;
                        case "ft":
                            outputNumber = (number / km) *ft;
                            break;
                        case "yd":
                            outputNumber = (number / km) *yd;
                            break;
                        case "km":
                            outputNumber = number;
                            break;
                        default: break;
                    }
                    break;

                case "ft":
                    switch (outputMetric.ToLower())
                    {
                        case "m":
                            outputNumber = number / ft;
                            break;
                        case "cm":
                            outputNumber = (number / ft)*cm;
                            break;
                        case "mi":
                            outputNumber = (number / ft) *mi;
                            break;
                        case "in":
                            outputNumber = (number / ft) *inch;
                            break;
                        case "km":
                            outputNumber = (number / ft) *km;
                            break;
                        case "mm":
                            outputNumber = (number / ft) * mm;
                            break;
                        case "yd":
                            outputNumber = (number / ft) *yd;
                            break;
                        case "ft":
                            outputNumber = number;
                            break;
                        default: break;
                    }
                    break;

                case "yd":
                    switch (outputMetric.ToLower())
                    {
                        case "m":
                            outputNumber = number / yd;
                            break;
                        case "cm":
                            outputNumber = (number / yd)*cm;
                            break;
                        case "mi":
                            outputNumber = (number / yd) *mi;
                            break;
                        case "in":
                            outputNumber = (number / yd) *inch;
                            break;
                        case "km":
                            outputNumber = (number / yd) *km;
                            break;
                        case "ft":
                            outputNumber = (number / yd) *ft;
                            break;
                        case "mm":
                            outputNumber = (number / yd) *mm;
                            break;
                        case "yd":
                            outputNumber = number;
                            break;
                        default: break;
                    }
                    break;

                default: break;
            }

            Console.WriteLine(Math.Round(outputNumber,8)+" "+outputMetric);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var input = Console.ReadLine().ToLower();
            var output = Console.ReadLine().ToLower();

            //var meter = 1;
            //var mm = 1000;
            //var cm = 100;
            //var mi = 0.000621371192;
            //var in = 39.3700787;
            //var km = 0.001;
            //var ft = 3.2808399;
            //var yd = 1.0936133;


            switch ( input )
            {
                case "meter":
                    break;
                case "mm":
                    num = num / 1000;
                    break;
                case "cm":
                    num = num / 100;
                    break;
                case "mi":
                    num = num / 0.000621371192;
                    break;
                case "in":
                    num = num / 39.3700787;
                    break;
                case "km":
                    num = num / 0.001;
                    break;
                case "ft":
                    num = num / 3.2808399;
                    break;
                case "yd":
                    num = num / 1.0936133;
                    break;
                default:
                    break;
            }
            switch (output)
            {
                case "meter":
                    break;
                case "mm":
                    num = num * 1000;
                    break;
                case "cm":
                    num = num * 100;
                    break;
                case "mi":
                    num = num * 0.000621371192;
                    break;
                case "in":
                    num = num * 39.3700787;
                    break;
                case "km":
                    num = num * 0.001;
                    break;
                case "ft":
                    num = num * 3.2808399;
                    break;
                case "yd":
                    num = num * 1.0936133;
                    break;
                default:
                    break;
            }
            Console.WriteLine(num + " " + output);
        }
    }
}

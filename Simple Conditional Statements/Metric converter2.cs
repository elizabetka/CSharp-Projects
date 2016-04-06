using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9.Metric_Converter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var input = Console.ReadLine().ToLower();
            var output = Console.ReadLine().ToLower();

          

            if (input == "km")
            {
                num = num / 0.001;
            }
            else if (input == "mm")
            {
                num = num / 1000;
            }
            else if (input == "cm")
            {
                num = num / 100;
            }
            else if (input == "mi")
            {
                num = num / 0.000621371192;
            }
            else if (input == "inch")
            {
                num = num / 39.3700787;
            }
            else if (input == "ft")
            {
                num = num / 3.2808399;
            }
            else if (input == "yd")
            {
                num = num / 1.0936133;
            }

            if (output == "km")
            {
                num = num * 0.001;
            }
            else if (output == "mm")
            {
                num = num * 1000;
            }
            else if (output == "cm")
            {
                num = num * 100;
            }
            else if (output == "mi")
            {
                num = num * 0.000621371192;
            }
            else if (output == "inch")
            {
                num = num * 39.3700787;
            }
            else if (output == "ft")
            {
                num = num * 3.2808399;
            }
            else if (output == "yd")
            {
                num = num * 1.0936133;
            }
            Console.WriteLine(num + " " + output);
        }
    }
}


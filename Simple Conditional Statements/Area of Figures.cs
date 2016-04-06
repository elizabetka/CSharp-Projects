using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            var type = Console.ReadLine();
            var area = 0.0;

            if (type == "square")
            {

                var a = double.Parse(Console.ReadLine());
                area = area + a * a;
            }
            else if (type == "rectangle")
            {
                var a1 = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                area = area + a1 * b;
            }
            else if (type == "circle ")
            {
                var r = double.Parse(Console.ReadLine());
                area = area + Math.PI * r * r;
            }
            else if (type == "triangle ")
            {
                var a = double.Parse(Console.ReadLine());
                var ha = double.Parse(Console.ReadLine());
                area = area + (a*ha)/2;
            }
            Console.WriteLine(Math.Round(area,3));
        }
    }
}

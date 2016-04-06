using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var rows = double.Parse(Console.ReadLine());
            var cols = double.Parse(Console.ReadLine());
            var premiere = 12.0;
            var normal = 7.50;
            var discount = 5.00;


            if (projection=="premiere")
            {
                Console.WriteLine("{0:f2} Leva", rows*cols*premiere);
            }
            else if (projection == "normal")
            {
                Console.WriteLine("{0:f2} Leva", rows * cols * normal);
            }
            else if (projection == "discount")
            {
                Console.WriteLine("{0:f2} Leva", rows * cols * discount);
            }

        }
    }
}

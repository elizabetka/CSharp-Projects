using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if ((x >= 0) && (x <= 3 * h) && (y >= 0) && (y <= h))
            {
                if ((x > 0) && (x < 3 * h) && (y > 0) && (y < h)) { Console.WriteLine("inside"); }
                else if ((x > h) && (x < 2 * h) && (y == h)) { Console.WriteLine("inside"); }
                else { Console.WriteLine("border"); }
            }
            else if ((x >= h) && (x <= 2 * h) && (y >= h) && (y <= 4 * h))
            {
                if ((x > h) && (x < 2 * h) && (y > h) && (y < 4 * h)) { Console.WriteLine("inside"); }
                else if ((x > h) && (x < 2 * h) && (y == h)) { Console.WriteLine("inside"); }
                else { Console.WriteLine("border"); }
            }

            else { Console.WriteLine("outside"); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = double.Parse(Console.ReadLine());
            var secondInput  = double.Parse(Console.ReadLine());
            var point = double.Parse(Console.ReadLine());

            var first = Math.Min(firstInput, secondInput);
            var second = Math.Max(firstInput, secondInput);

            if (point >= first && point <= second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            var one = Math.Abs(first-point);
            var two = Math.Abs(second - point);
            if (one < two)
            {
                Console.WriteLine(one);
            }
            else
            {
                Console.WriteLine(two);
            }
        }
    }
}

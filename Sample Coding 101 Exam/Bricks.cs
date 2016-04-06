using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._02.Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var brickCount = double.Parse(Console.ReadLine());
            var workersCount = double.Parse(Console.ReadLine());
            var vmestimostNaKolichkata = double.Parse(Console.ReadLine());

            var naiMalkoKursove=brickCount/(workersCount*vmestimostNaKolichkata);

            Console.WriteLine(Math.Ceiling(naiMalkoKursove));
        }
    }
}
//Math.Floor rounds down, Math.Ceiling rounds up, and Math.Truncate rounds towards zero. Thus, Math.Truncate is like Math.Floor for positive numbers, and like Math.Ceiling for negative numbers. Here's the reference.

//For completeness, Math.Round rounds to the nearest integer.If the number is exactly midway between two integers, then it rounds towards the even one.Reference.
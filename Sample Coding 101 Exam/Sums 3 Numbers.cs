using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._06.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var min = Math.Min(Math.Min(a,b),c);
            var max = Math.Max(Math.Max(a, b), c);

            var sum = a + b + c;
            var mid = sum - min - max;

            if (min+mid==max)
            {
                Console.WriteLine(min + "+" + mid+ "=" + max);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

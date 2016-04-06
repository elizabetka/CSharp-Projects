using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var factorial = 1;

            do
            {
                factorial = factorial * n;
            } while (n>1);
            Console.WriteLine(factorial);
        }
    }
}

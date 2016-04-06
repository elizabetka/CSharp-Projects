using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            if (n >= 100 && n <= 200 || n==0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

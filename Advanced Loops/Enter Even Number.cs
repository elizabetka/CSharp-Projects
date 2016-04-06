using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter even number:");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even");
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
            }

            Console.WriteLine("n={0}", n);
        }
    }
}

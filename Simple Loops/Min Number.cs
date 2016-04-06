using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < n; i++)
            {

                var num = int.Parse(Console.ReadLine());

                if (min>num)
                {
                    min = num;
                }
            }
            Console.WriteLine("The min number is: {0}", min);
        }
    }
}

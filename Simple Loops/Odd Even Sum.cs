using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var sumEven = 0;
            var sumOdd = 0;



            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven = sumEven + num1;

                }
                else
                {
                    sumOdd = sumOdd + num1;
                }
            }
                if (sumEven == sumOdd)
                {
                    Console.WriteLine("Yes, sum = {0}", sumOdd);
                }
                else
                {
                    var diff = Math.Abs(sumOdd - sumEven);
                    Console.WriteLine("No diff = {0}", diff);
                }
            }
        }
    }


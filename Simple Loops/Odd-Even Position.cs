using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._17.Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = double.Parse(Console.ReadLine());
            double OddSum = 0.0;
            double OddMin = 1000000000.0;
            double OddMax = -1000000000.0;
            double EvenSum = 0.0;
            double EvenMin = 1000000000.0;
            double EvenMax = -1000000000.0;

            for (int i = 1; i <= n; i++)
            {

                var nums = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum = EvenSum + nums;
                }
                else
                {
                    OddSum = OddSum + nums;
                }

                if (i % 2 == 0)
                {
                    if (nums >EvenMax)
                    {
                        EvenMax = nums;
                    }
                    if (nums < EvenMin)
                    {
                        EvenMin = nums;
                    }
                }
                if (i % 2 == 1)
                {
                    if (nums > OddMax)
                    {
                        OddMax = nums;
                    }
                    if (nums < OddMin)
                    {
                        OddMin = nums;
                    }

                }
            }

            Console.WriteLine("oddsum = {0}", OddSum);

            if (OddMin == 1000000000.0)
            {
                Console.WriteLine("oddmin = No");
            }
            else
            {
                Console.WriteLine("oddmin = {0}", OddMin);
            }
            if (OddMax == -1000000000.0)
            {
                Console.WriteLine("oddmax = No");
            }
            else
            {
                Console.WriteLine("oddmax = {0}", OddMax);
            }

            Console.WriteLine("evensum = {0}", EvenSum);

            if (EvenMin == 1000000000.0)
            {
                Console.WriteLine("evenmin = No");
            }
            else
            {
                Console.WriteLine("evenmin = {0}", EvenMin);
            }
            if (EvenMax == -1000000000.0)
            {
                Console.WriteLine("evenmax= No");
            }
            else
            {
                Console.WriteLine("evenmax = {0}", EvenMax);
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._16.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = 0;


            for (int i = 0; i < n; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                if (nums > max)
                {
                    max = nums;
                }
                sum = sum + nums;
            }
                ////////////////////////////////////////////
            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes, Sum= {0}", sum);
            }
            else
            {
                Console.WriteLine("No, diff= {0}", Math.Abs(sum- max));
            }
      }
   }
}


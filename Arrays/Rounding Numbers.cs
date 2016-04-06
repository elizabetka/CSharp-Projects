using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._06.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int rounded;
                if (nums[i] < 0)
                {
                     rounded = (int)(nums[i] - 0.5);
                }
                else
                {
                     rounded = (int)(nums[i] + 0.5);
                }
                
                Console.WriteLine("{0} => {1}", nums[i], rounded);
            }
        }
    }
}

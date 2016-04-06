using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._05.Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;
            for (int left = 0; left < nums.Length; left++)
            {
                for (int right = left + 1; right < nums.Length; right++)
                {
                    var sum = nums[left] + nums[right];
                    if (nums.Contains(sum)) // contains -съдържа - ако Nums съдържа числото sum, само тогава се печата
                    {
                        Console.WriteLine("{0} + {1} == {2}", nums[left], nums[right], sum);
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
//Write a program to read an array of integers and find all triples of elements a, b and c, such that a + b == c(a stays left from b)


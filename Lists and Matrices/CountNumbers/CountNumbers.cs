using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            //var count = new int[nums.Max() + 1];

            //foreach (var num in nums)
            //{
            //    count[num]++;
            //}
            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] !=0) // за да махнем излишните нули
            //    {
            //        Console.WriteLine("{0} -> {1}", i, count[i]);
            //    }

            //}

            //Втори начин
            nums.Sort();
            for (int start = 0; start < nums.Count; start++)
            {
                int end = 1;
                while (start + end < nums.Count && nums[start]==nums[start + end]) //start е от където тръгваме, end-колко са на брой еднаквите
                {
                    end++;
                }
                start = start + end-1;
                Console.WriteLine($"{nums[start]} -> {end}");
            }
        }
    }
}

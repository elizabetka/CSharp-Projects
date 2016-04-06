using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._09.Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length-1; i++)
                {
                    condensed[i] = condensed[i % nums.Length] + nums[nums.Length-1];// как да стане събирането??
                }
                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
//Reads an array of integers and condense them by summing adjacent couples of elements until a single integer is obtained
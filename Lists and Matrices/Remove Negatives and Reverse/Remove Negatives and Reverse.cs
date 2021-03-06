﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    if (nums[i] < 0)
            //    {
            //        nums.RemoveAt(i);
            //        i--;
            //    }
            //}
            //nums.Reverse();
            //if (nums.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}
            //else
            //{
            //    Console.WriteLine(" ", nums);
            //}

            //Втори начин
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var positives = new List<int>();
            foreach (var num in nums)
            {
                if (num >= 0)
                {
                    positives.Add(num);
                }
            }
            positives.Reverse();
            if (positives.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", positives));
            }
            //вместо да трием отрицателните, минаваме и събираме тези, които не са за изтриване
        }
    }
}
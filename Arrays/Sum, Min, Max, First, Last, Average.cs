using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._04.Sum__Min__Max__First__Last__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int n = int.Parse(Console.ReadLine());
            //    var nums = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //        nums[i] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("Sum = {0}", nums.Sum());
            //    Console.WriteLine("Min = {0}", nums.Min());
            //    Console.WriteLine("Max = {0}", nums.Max());
            //    Console.WriteLine("First = {0}", nums.First());
            //    Console.WriteLine("Lasts = {0}", nums.Last());
            //    Console.WriteLine("Average = {0}", nums.Average());
//Втори начин на решаване
            int n = int.Parse(Console.ReadLine());
            var nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            var sum = nums[0];
            var min = nums[0];
            var max = nums[0];
            var first = nums[0];
            var last = nums[n-1];
            //var last = nums[nums.Lenght-1]; може и така

            for (int i = 1; i < n; i++)
            {
                sum += nums[i];

                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            var average = (double)sum / n;

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("first = {0}", first);
            Console.WriteLine("lasts = {0}", last);
            Console.WriteLine("average = {0}", average);
        }


    }
    }


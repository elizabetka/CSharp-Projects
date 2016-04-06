using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._08.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var n = Math.Max(arr1.Length, arr2.Length); // защо ми е да намирам максималното от двете????

            var sumArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
//Write a program that reads two arrays of integers and sums them
//When elements are less, duplicate the smaller array a few times - кой код се грижи за това ????
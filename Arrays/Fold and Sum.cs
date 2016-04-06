using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = int.Parse(Console.ReadLine()) * 4;
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrOriginal = new int[n];
            int[] arrA = new int[n / 2];
            int[] arrB = new int[n / 2];
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < n; i += 1)
            {
                arrOriginal[i] = int.Parse(Console.ReadLine());
                if (i >= n && i < 3 * n)
                {
                    arrA[countA] = arrOriginal[i];
                    countA += 1;
                }
                else if (i < n)
                {
                    arrB[(n - 1) - countB] = arrOriginal[i];
                    countB += 1;
                }
                else if (i >= 3 * n)
                {
                    arrB[countB + (n - 1)] = arrOriginal[i];
                    countB -= 1;
                }
            }
            for (int j = 0; j < n * 2; j += 1)
            {
                int sum = (arrA[j]) + (arrB[j]);
                Console.Write(sum + " ");
            }
        }
    }
}

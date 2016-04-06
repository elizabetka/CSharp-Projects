using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10.Middle_elements
{
    class Program
    {
        //static void Main(string[] args)
        //{
            static int[] ExtractMiddleElements(int[] arr)
{
                int start = arr.Length / 2 - 1;
                int end = start + 2;
                if (arr.Length == 1) start = end = 0;
                else if (arr.Length % 2 == 0) end--;
                int[] mid = new int[end - start + 1];
                // Copy arr[start … end]  mid[]
                return mid;
            }
    }
}

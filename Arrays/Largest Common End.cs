using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10.Largest_Common_End
{
    class Program
    {
        //static void Main(string[] args)
        //{

        static int LargestCommonEnd(
   string[] words1, string[] words2)
        {
            var rightCount = 0;
            while (rightCount < words1.Length &&
                   rightCount < words2.Length)
                if (words1[words1.Length - rightCount - 1] ==
                     words2[words2.Length - rightCount - 1])
                    rightCount++;
                else break;
            return rightCount;
        }


    }

}
    

//Read two arrays of words and find the length of the largest common end(left or right)

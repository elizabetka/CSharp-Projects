using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var len = 0;
            var maxLen = 0;
            var prev = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if ((i==0)||(num>prev))
                {
                    len++;
                }
                else
                {
                    len = 1;
                }
                if (len > maxLen) maxLen = len;
                {
                    prev = num;
                }
            }
            Console.WriteLine(maxLen);
        }
    }
}

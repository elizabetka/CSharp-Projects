using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._18.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int currentSum = 0, prevSum = 0, diff = 0, bigDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    prevSum = firstNum + secondNum;
                }
                else
                {
                    currentSum = firstNum + secondNum;
                    diff = Math.Abs(currentSum - prevSum);
                    if (bigDiff < diff) 
                    {
                        bigDiff = diff;
                        prevSum = currentSum;
                    }
                }
            }
            if (bigDiff == 0)
            {
                Console.WriteLine("Yes, value = " + prevSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff = " + bigDiff);
            }
        }
    }
}

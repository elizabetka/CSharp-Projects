using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
                if (Palindrome(num) &&
                   (SumOfDigits(num) % 7 == 0) &&
                   EvenDigits(num))
                {
                    Console.WriteLine(num);
                }

        }

        static bool Palindrome(int num)
        {
            string digits = "" + num;
            for (int i = 0; i < digits.Length / 2; i++)
                if (digits[i] != digits[digits.Length - i - 1])
                    return false;
            return true;

        }
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;

        }
        static bool EvenDigits(int num)
        {
            string digits = "" + num;
            for (int i = 0; i < digits.Length; i++)
            {
                int digit = digits[i] - '0';
                if (digit % 2 == 0)
                {
                    return true;
                }
                // TODO: return true if the digit is even
            }
            return false;

        }
    }
}

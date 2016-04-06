using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int digits = 0;

                while (num > 0)
                {
                    digits += num % 10;
                    num /= 10;
                }
                bool isSpecial = (digits == 5 || digits == 7 || digits == 11);

                Console.WriteLine($"{i} --> {isSpecial}");
            }
        }
    }
}
//A number is special when its sum of digits is 5, 7 or 11
//For all numbers 1…n print the number and if it is special
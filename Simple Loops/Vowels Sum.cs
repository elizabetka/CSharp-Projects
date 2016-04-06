using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._9.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                if (letter == 'a')
                {
                    sum = sum + 1;
                }
                else if (letter=='e')
                {
                    sum = sum + 2;
                }
                else if (letter == 'i')
                {
                    sum = sum + 3;
                }
                else if (letter == 'o')
                {
                    sum = sum + 4;
                }
                else if (letter == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

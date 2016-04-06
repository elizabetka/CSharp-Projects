using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._02.Count_Letters_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();

            int[] count = new int[str.Max() + 1];

            foreach (var letter in str)
            {
                count[letter]++;
            }
            for (int i = 0; i < count.Length; i++)
                if (count[i]>0)
                {
                    var letter = (char)i;
                    var occirencies = count [i];
                    Console.WriteLine("{0} --> {1}", letter,occirencies);
                }
            {

            }
        }
    }
}

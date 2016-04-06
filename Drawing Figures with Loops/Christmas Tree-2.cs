using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7._1.Christmas_Tree_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {

                Console.WriteLine(new string(' ', n - i) + new string('*', i) + " | " + new string('*', i) + new string(' ', n - i));
            }
        }
    }
}

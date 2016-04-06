using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                //Console.Write("*");
                for (int col = 0; col < n; col++)
                {
                    //Console.Write(" ");
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

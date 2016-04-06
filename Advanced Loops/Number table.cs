using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col + 1 + row > n)
                    {
                        Console.Write(n * 2 - (col + 1 + row));
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(col + 1 + row);
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
    }
}

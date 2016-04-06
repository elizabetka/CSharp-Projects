using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Filled_Square
{
    class Program
    {
        static void PrintStart(int count)
        {
            Console.WriteLine(new string ('*',count));
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                PrintStart(i+1);
            }
            //PrintStart(1);
            //PrintStart(2);
            //PrintStart(3);
            //PrintStart(4);
            //PrintStart(5);
        }
    }
}

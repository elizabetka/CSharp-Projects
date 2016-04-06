using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    for (int i3 = 0; i3 < n; i3++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)('a' + i1), (char)('a' + i2), (char)('a' + i3));
                    }
                 }
             }
         }
    }
}

//Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically.

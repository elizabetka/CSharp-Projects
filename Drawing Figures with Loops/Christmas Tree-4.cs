using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree_4
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row <= n; row++)
            {
                var asteriskCount = row;
                var spacesCount = n - row;
                var spaces = new string(' ',spacesCount);
                var asterisk = new string('*',asteriskCount);
                Console.WriteLine(spaces+asterisk+" | "+ asterisk+spaces);
            }
        }
    }
}

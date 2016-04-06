using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string b = new string('*', n - 2);
            for (int i = 1; i <= n; i += 2)
            {
                string a = new string('*', i);
                string c = new string('-', ((n - i) / 2));
                Console.WriteLine("{0}{1}{0}", c, a);
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("{0}{1}{0}", '|', b);
            }
        }
    }
}

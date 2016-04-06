using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._09.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'!? ".ToCharArray();
            var words = Console.ReadLine().ToLower()
              .Split(separators);
            var result = words
              .Where(w => w != "")
              .Where(w => w.Length <5)
              .OrderBy(w => w)
              .Distinct();
            Console.WriteLine(string.Join(", ", result));

        }
    }
}

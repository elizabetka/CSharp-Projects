using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "Pesho", "Kiro", "Maria", "Asen" };

            Console.WriteLine(string.Join(" ", names));
            names.Sort();
            names.Reverse();//за да сортираме на обратно
            Console.WriteLine(string.Join(" ", names));
        }
    }
}

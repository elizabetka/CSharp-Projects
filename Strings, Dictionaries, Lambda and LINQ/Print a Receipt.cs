using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._03.Print_a_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Console.WriteLine(@"/----------------------\"); // @ изключва ескейпването

            foreach (var num in nums)
            {
                Console.WriteLine("|{0,21:f2} |", num);
            }
            Console.WriteLine(@"|----------------------|");
            Console.WriteLine("| Total:{0,14:f2} |", nums.Sum());
            Console.WriteLine(@"\----------------------/");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            var sum = 0;


            while (num>0)
            {
                var digits = num % 10;
                sum = sum + digits;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            

            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                sum1 = sum1 + num1;
            }

            var sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                var num2 = int.Parse(Console.ReadLine());
                sum2 = sum2 + num2;

            }
            if (sum1==sum2)
            {
                Console.WriteLine("The sum is : {0}", sum1);
            }
            else
            {
                var diff = Math.Abs(sum1- sum2);
                Console.WriteLine("No");
                Console.WriteLine("diff = {0}",diff);
            }
        }
    }
}

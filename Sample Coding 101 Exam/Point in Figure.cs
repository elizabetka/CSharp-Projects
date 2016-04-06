using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._04.Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var insideLeft=((x>=2 && x<=12)&&(y>=-3 && y<=1));

            var insideRight = ((x>=4 && x<=10)&&(y>=-5 && y<=3));

            if (insideLeft || insideRight)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            
        }
    }
}

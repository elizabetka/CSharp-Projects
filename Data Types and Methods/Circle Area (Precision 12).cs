using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;

            Console.WriteLine("{0:f12}",area);
        }
    }
}

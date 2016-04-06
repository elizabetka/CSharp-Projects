using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12.Rotate_and_Sum_RDY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotate = int.Parse(Console.ReadLine());
            int[] sumResult = new int[data.Length];

            for (int i = 0; i < rotate; i++)
            {
                int lastElement = data[data.Length - 1];
                for (int e = data.Length - 1; e > 0; e--)
                {
                    data[e] = data[e - 1];
                }
                data[0] = lastElement;
                for (int w = 0; w < data.Length; w++)
                {
                    sumResult[w] += data[w];
                }
            }
            Console.WriteLine(string.Join(" ", sumResult));
        }
    }
}

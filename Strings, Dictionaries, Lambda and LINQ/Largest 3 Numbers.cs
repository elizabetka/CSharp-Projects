using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._08.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = Console.ReadLine().Split(' ');
            List<int> nums = strings.Select(int.Parse).ToList();
            var sortedNums = nums.OrderBy(x => -x);
            var largest3Nums = sortedNums.Take(3);
            Console.WriteLine(string.Join(" ", largest3Nums));







            //var arr = new int[] { 20,30,40,120,7,14,5};

            //Console.WriteLine(string.Join(" ",arr.OrderBy(x => -x).Take(3)));// масива, сортирай ми го, така, че всяко число x ми вземи -x, когато сортира в обратен ред и ми вземи последните 3

            //(x => -x)  Това се нарича Lambda функция, която казва по какво да сортирам. Това е функция, която взима някакъв вход и връща някакъв изход
        }
    }
}

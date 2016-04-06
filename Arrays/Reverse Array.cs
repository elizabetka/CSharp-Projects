using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._07.Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length / 2; i++)
            {
                var old = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = old;
            }
            //// със string.join печатам вместо foreach
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(string.Join(", ", nums)); //string.join стрингосва nums с разделителя отпред, в случая запетайка следвана от интервал


            ////втори начин
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //var result = nums.Reverse().ToArray();

            //Console.WriteLine(string.Join(", ", nums)); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|').ToList();
            var result = new List<string>();

            for (int i = lists.Count - 1; i >= 0; i--)
            {
                var currentList = lists[i].Split(' ');
                foreach (var item in currentList)
                {
                    if (item != "")
                    {
                        result.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
//Write a program to append several lists of numbers
//Lists are separated by |
//Values are separated by spaces(one or several)
//Order the lists from last to first, and their values from left to right
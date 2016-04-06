using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            if (name == "banana" || name == "apple" || name == "kiwi" || name == "cherry" || name == "lemon" || name == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (name == "tomato" || name == "cucumber" || name == "pepper" || name == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {

            var age = double.Parse(Console.ReadLine());
            var pol = Console.ReadLine();

            if (age >=16 && pol == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (age >= 16 && pol == "f")
            {
                Console.WriteLine("Ms.");
            }
            if (age <16 && pol == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age < 16 && pol == "f")
            {
                Console.WriteLine("Miss");
            }
        }
    }
}

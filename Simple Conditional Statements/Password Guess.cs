using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {

            var password = Console.ReadLine();
            var realPassword = "s3cr3t!P@ssw0rd";

            if (password == realPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                //Първата част- първи и последен символ от реда, да са +, иначе- |
                if (row == 0 || row == n - 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }
                //Втората част-печатаме "-"
                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write(" -");
                }
                //Третата част отпечатваме първи и последен символ от дясната част на квадрата.Третата част == Първата част
                if (n > 1)
                {
                    Console.Write(" ");
                }
                if (row == 0 || row == n - 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }
                Console.WriteLine();
            }

        }
        }
    }


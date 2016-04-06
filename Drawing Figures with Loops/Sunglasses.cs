using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._08.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var middleRow = n / 2 + n % 2;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n * 2; col++)
                {
                    if (row == 0 || row == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (col == 0 || col == n * 2 - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }

                    }

                }
                //middle
                for (int i = 0; i < n; i++)
                {
                    //  Console.Write("|");
                    if (middleRow - 1 == row)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                //right part
                for (int col = 0; col < n * 2; col++)
                {
                    if (row == 0 || row == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (col == 0 || col == n * 2 - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }

                    }


                }
                Console.WriteLine();

            }
        }
    }
}

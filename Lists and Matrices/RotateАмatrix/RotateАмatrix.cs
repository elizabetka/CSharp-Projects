using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateАмatrix
{
    class RotateАмatrix
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                var items = line.Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = items[col];
                }
            }
            var resultCols = rows;
            var resultRows = cols;
            var result = new string[resultRows, resultCols];
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cols; col++)
                {
                    result[col,resultCols- row-1] = matrix[row,col];
                }
            }
            for (int row = 0; row < cols; row++)
            {

                for (int col = 0; col < rows; col++)
                {
                    Console.Write(result[row, col] + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}

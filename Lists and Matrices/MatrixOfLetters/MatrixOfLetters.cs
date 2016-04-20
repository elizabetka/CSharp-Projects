using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfLetters
{
    class MatrixOfLetters
    {
        static void Main(string[] args)
        {
            //var matrix = new char[12, 9];
            //var rows = matrix.GetLength(0); //12
            //var cols = matrix.GetLength(1);//9
            //char letter = 'A';

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        matrix[row, col] = letter;
            //        letter++;
            //        if (letter > 'Z')//за да рестарираме от А, когато стигнем Z
            //        {
            //            letter = 'A';
            //        }
            //    }
            //}
            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write(matrix[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //втори начин

            //int rows =  int.Parse(Console.ReadLine());
            //int cols =  int.Parse(Console.ReadLine());
            //int [,]numbers  = new int[rows, cols];

            //for (int row = 0; row < numbers.GetLength(0); row++)
            //{
            //    for (int col = 0; col < numbers.GetLength(1); col++)
            //    {
            //        numbers[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write(numbers[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //трети начин
            //int rows =  int.Parse(Console.ReadLine());
            //int cols =  int.Parse(Console.ReadLine());
            //var matrix = new char[rows, cols];
            //char letter = 'A';
            //for (int row = 0; row < rows; row++)
            //    for (int col = 0; col < cols; col++)
            //        matrix[row, col] = letter++;
            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols - 1; col++)
            //        Console.Write(matrix[row, col] + " ");
            //    Console.WriteLine(matrix[row, cols - 1]);
            //}
           
            //четвърти най-начин
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            
            char symbol = 'A';
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    Console.Write(symbol + " ");
                    symbol++;
                }
                Console.WriteLine();
            }
        }
    }
}

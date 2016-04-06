using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01.Days_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            // int [] numbers = new int [10]; - създаване на нов масив
            //[i] - оператор за индексация. достъп до индекс. прави директен достъп до определена позиция.
            string [] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int n = int.Parse(Console.ReadLine());

            //days[days.Length - 1] = "blqblq";  За да променя последния елемент на масива.

            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            if (n < 1 || n > 7)
            {
                Console.WriteLine("Invalid day");
            }
            else
            {
               var day = days[n-1];
                Console.WriteLine(day);
            }
        }
    }
}

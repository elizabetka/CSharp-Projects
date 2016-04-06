using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5.Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = double.Parse(Console.ReadLine());
            var month = double.Parse(Console.ReadLine());

            var daysInTheMonth = 31;
            if (month==4 || month == 6 || month== 9|| month == 11)
            {
                daysInTheMonth = 30;
            }
            else if(month==2)
            {
                daysInTheMonth = 28;
            }

            day = day + 5;
            if (day>daysInTheMonth)
            {
                day = day - daysInTheMonth;
                month++;
                if (month==13)
                {
                    month = 1;
                }
            }
            if (month<10)
            {
                Console.WriteLine("{0}.0{1}", day, month);
            }
            else
            {
                Console.WriteLine("{0}.{1}", day, month);
            }
            

        }
    }
}

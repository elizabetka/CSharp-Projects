using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._16.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursInMinutes = int.Parse(Console.ReadLine()) * 60;
            var minutes = int.Parse(Console.ReadLine());
            var allMinutes = hoursInMinutes + minutes + 15;
            var hoursActual = (allMinutes / 60) % 24;
            var minutesActual = allMinutes % 60;
            Console.WriteLine(String.Format("{0}:{1:00}", hoursActual, minutesActual));
        }
    }
}

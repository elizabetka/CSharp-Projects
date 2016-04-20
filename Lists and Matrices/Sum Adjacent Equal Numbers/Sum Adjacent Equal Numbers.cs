using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            //for (int i = 0; i < nums.Count - 1; i++)
            //{
            //    if (nums[i] == nums[i + 1])
            //    {
            //        nums[i] == nums[i] + nums[i + 1];
            //        nums.RemoveAt(i + 1);
            //        i = i - 2;

            //        if (i < 0)
            //        {
            //            i = -1;
            //        }
            //    }
            //}
            //Console.WriteLine(string.Join(" ", nums));

            // втори начин
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var pos = 0;//започваме от позиция 0

            while (pos < nums.Count - 1) // ходи на дясно до тогава, докато сме на позиция такава, че има и следваща. Има и следваща, когато позицията е по-малка от последната - count -1
            {
                if (nums[pos] == nums[pos + 1])// сравни дали текущата и следващата съвпадат
                {
                    nums[pos] = nums[pos] + nums[pos + 1];// ако има съвпадение-сумирай
                    nums.RemoveAt(pos + 1);// ако имаме съвпадение в сравнението, махни последната
                    pos--;//и след това отиди с една на ляво
                    if (pos < 0)
                    {
                        pos = 0;
                    }
                }
                else // ако не е имало съвпадение само тогава ходи на дясно
                {
                    pos++;
                }

            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

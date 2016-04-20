using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var separators = ",;:.!()\"'/\\[] ".ToArray();
            var words = s.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            var lowerWords = new List<string>();
            var upperWords = new List<string>();
            var mixedWords = new List<string>();


            foreach (var w in words)//w-текущата дума; words-всички думи. За всяка дума w сред думите, направи следното:
            {
                var lowerLetters = 0;
                var upperLetters = 0;

                foreach (var letter in w)
                {
                    if (char.IsLower(letter))
                    {
                        lowerLetters++;
                    }
                    if (char.IsUpper(letter))
                    {
                        upperLetters++;
                    }
                }
                if (upperLetters == w.Length)//ако всички букви са главни
                {
                    upperWords.Add(w);//ги добавяме в списъка с главни
                }
               else if (lowerLetters == w.Length)
                {
                    lowerWords.Add(w);
                }
                else
                {
                    mixedWords.Add(w);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperWords));        }
    }
}

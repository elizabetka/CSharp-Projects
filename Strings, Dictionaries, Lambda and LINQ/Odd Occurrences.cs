using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._07.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var allWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!allWords.ContainsKey(word))
                {
                    allWords.Add(word, 1);

                }
                else
                {
                    allWords[word]++;
                }
                var result = new List<string>();
                foreach (var pair in allWords)
                {
                    if (pair.Value % 2 ==1)
                    {
                        result.Add(pair.Key);
                    }
                }
                Console.WriteLine(string.Join(", ", result));
            }
            
        }
        
        }

        
        }
    


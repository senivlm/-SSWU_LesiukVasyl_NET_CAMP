using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_3
{
    public class TextAnalyzer
    {
        public static IEnumerable<string> UniqueWords(string text)
        {
            HashSet<string> uniqueWords = new HashSet<string>();
            foreach (string word in text.Split(' '))
            {
                if (uniqueWords.Add(word))
                {
                    yield return word;
                }
            }
        }
    }
}

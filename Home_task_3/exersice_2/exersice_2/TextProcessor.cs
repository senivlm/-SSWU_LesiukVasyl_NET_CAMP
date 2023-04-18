using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exersice_2
{
    public class TextProcessor
    {
        private string _text;

        public TextProcessor(string text)
        {
            _text = text;
        }

        public string Text
        {
            get { return _text; }
        }

        public int? FindSecondSubstringIndex(string substring)
        {
            int firstIndex = _text.IndexOf(substring);
            if (firstIndex == -1) return null;
            int secondIndex = _text.IndexOf(substring, firstIndex + substring.Length);
            // Навіщо приведення до типу?
            return secondIndex != -1 ? secondIndex : (int?)null;
        }

        public int CountWordsStartingWithCapitalLetter()
        {
            int count = 0;
            bool newWord = true;
            foreach (char c in _text)
            {
                if (char.IsWhiteSpace(c))
                {
                    newWord = true;
                }
                else if (newWord && char.IsUpper(c))
                {
                    count++;
                    newWord = false;
                }
                else
                {
                    newWord = false;
                }
            }
            return count;
        }

        public void ReplaceWordsWithDoubleLetters(string replacement)
        {
            string[] words = _text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                bool hasDoubleLetters = false;
                for (int j = 0; j < words[i].Length - 1; j++)
                {
                    if (words[i][j] == words[i][j + 1])
                    {
                        hasDoubleLetters = true;
                        break;
                    }
                }
                if (hasDoubleLetters)
                {
                    words[i] = replacement;
                }
            }
            // Загублено початкову конфігурацію пробільних символів.
            _text = string.Join(' ', words);
        }
    }
}

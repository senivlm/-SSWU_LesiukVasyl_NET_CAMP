using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_1
{// Вхідний текст мав бути колекцією стрічок і її не можна зливати в одну. Ви розв'язуєте алгоритмічно простішу задачу.
    public class SentenceCollection
    {
        private readonly List<string> _sentences = new List<string>();

        public SentenceCollection(string text)
        {
            string[] sentenceEndings = { ".", "!", "?", "," };
            string[] sentences = text.Split(sentenceEndings, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sentence in sentences)
            {
                if (sentence.Contains("(") && sentence.Contains(")"))
                {
                    _sentences.Add(sentence.Trim());
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (string sentence in _sentences)
            {
                builder.AppendLine(sentence);
            }

            return builder.ToString();
        }
    }
}

using System.Text;

namespace exersice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Це речення (з даними в дужках) містить інформацію.\n" +
                          "Це речення не містить дужок.\n" +
                          "Інформація (в дужках) знаходиться в цьому реченні.\n" +
                          "Це речення також не має дужок.";
            string engText = "This sentence (with information in parentheses) contains information.\n" +
                          "This sentence does not have parentheses.\n" +
                          "The information (in parentheses) is found in this sentence.\n" +
                          "This sentence also does not have parentheses.";
            SentenceCollection sentences = new SentenceCollection(text);
            Console.WriteLine(sentences);
            sentences = new SentenceCollection(engText);
            Console.WriteLine(sentences);
        }
    }
}
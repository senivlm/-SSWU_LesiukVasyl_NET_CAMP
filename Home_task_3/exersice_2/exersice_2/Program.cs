namespace exersice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string text = "Hello World! This is a test.";
            Console.WriteLine("Original text: " + text);

            TextProcessor processor = new TextProcessor(text);

            string substring = "is";
            int? secondIndex = processor.FindSecondSubstringIndex(substring);
            Console.WriteLine("Second index of substring '" + substring + "': " + secondIndex);

            int wordsStartingWithCapitalLetter = processor.CountWordsStartingWithCapitalLetter();
            Console.WriteLine("Words starting with capital letter: " + wordsStartingWithCapitalLetter);

            processor.ReplaceWordsWithDoubleLetters("REPLACEMENT");
            Console.WriteLine("Text after replacing words with double letters: " + processor.Text);
        }
    }
}
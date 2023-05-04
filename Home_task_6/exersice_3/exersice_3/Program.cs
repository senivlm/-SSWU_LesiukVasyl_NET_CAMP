namespace exersice_3
{// Сумарний бал 95
    internal class Program
    {
        static void Main()
        {
            string text = "це приклад тексту з дублікатами слів це приклад тексту з дублікатами слів";
            Console.WriteLine("Унікальні слова:");
            foreach (string word in TextAnalyzer.UniqueWords(text))
            {
                Console.WriteLine(word);
            }
        }
    }
}

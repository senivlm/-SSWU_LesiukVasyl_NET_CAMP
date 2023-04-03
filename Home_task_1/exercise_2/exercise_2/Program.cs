namespace exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(10, 10);
            matrix.FillMatrix(17);
            Console.WriteLine(matrix);

            var result = matrix.FindLongestHorizontalLine();
            Console.WriteLine("Колір найдовшої горизонтальної лінії: " + result.maxColor);
            Console.WriteLine("Її довжина: " + result.maxLength);
            Console.WriteLine("Індекси початку та кінця: (" + result.startRow + ", " + result.startCol + ") - (" + result.endRow + ", " + result.endCol + ")");
        }
    }
}
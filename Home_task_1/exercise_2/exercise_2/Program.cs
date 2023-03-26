namespace exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість рядків: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість стовпців: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(17);
                }
            }

            int maxColor = -1;
            int maxLength = 0;
            int startRow = -1;
            int startCol = -1;
            int endRow = -1;
            int endCol = -1;

            for (int i = 0; i < rows; i++)
            {
                int currentColor = matrix[i, 0];
                int currentLength = 1;
                int currentStartCol = 0;

                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] == currentColor)
                    {
                        currentLength++;
                    }
                    else
                    {
                        if (currentLength > maxLength)
                        {
                            maxColor = currentColor;
                            maxLength = currentLength;
                            startRow = i;
                            startCol = currentStartCol;
                            endRow = i;
                            endCol = j - 1;
                        }

                        currentColor = matrix[i, j];
                        currentLength = 1;
                        currentStartCol = j;
                    }
                }

                if (currentLength > maxLength)
                {
                    maxColor = currentColor;
                    maxLength = currentLength;
                    startRow = i;
                    startCol = currentStartCol;
                    endRow = i;
                    endCol = cols - 1;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Колір найдовшої горизонтальної лінії: " + maxColor);
            Console.WriteLine("Її довжина: " + maxLength);
            Console.WriteLine("Індекси початку та кінця: (" + startRow + ", " + startCol + ") - (" + endRow + ", " + endCol + ")");
        }
    }
}
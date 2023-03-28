namespace exercise_1
{
    internal class Program
    {//Вітаю. Перше завдання по створенню репозиторію Ви виконали.
        static void Main(string[] args)
        {
            int n = 3, m = 4;
            int[,] matrix = new int[n, m];
            int value = 1;
            int rows = n;
            int columns = m;

            int left = 0;
            int top = 0;
            int right = columns - 1;
            int bottom = rows - 1;

            while (left <= right && top <= bottom)
            {
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, left] = value;
                    value++;
                }
                left++;

                for (int i = left; i <= right; i++)
                {
                    matrix[bottom, i] = value;
                    value++;
                }
                bottom--;

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i, right] = value;
                        value++;
                    }
                    right--;
                }

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        matrix[top, i] = value;
                        value++;
                    }
                    top++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

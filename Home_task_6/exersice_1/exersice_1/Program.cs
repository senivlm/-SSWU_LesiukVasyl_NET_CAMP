namespace exersice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            SquareMatrix squareMatrix = new SquareMatrix(matrix);

            Console.WriteLine(squareMatrix);
        }
    }
}
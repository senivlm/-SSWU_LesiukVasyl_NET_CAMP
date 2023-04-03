namespace exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(10, 10);
            matrix.FillSpiral();
            Console.WriteLine(matrix);
        }
    }
}
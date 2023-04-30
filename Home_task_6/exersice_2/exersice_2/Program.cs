namespace exersice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 3, 5 };
            int[] array2 = new int[] { 2, 4, 6 };
            int[] array3 = new int[] { 0, 7, 8 };

            ArrayMerger arrayMerger = new ArrayMerger(array1, array2, array3);

            Console.WriteLine(arrayMerger.ToString());

            var result = arrayMerger.MergeAndSort();

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
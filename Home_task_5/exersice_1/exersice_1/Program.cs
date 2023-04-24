namespace exersice_1
{//Vasyl 	Lesiuk 90	5	18	90	85	90	50	92,5 вітаю вас в 2 турі.
    public class Program
    {
        static void Main(string[] args)
        {
            Garden garden1 = new Garden();
            garden1.AddRandomTrees(10, 10, 10);

            Garden garden2 = new Garden();

            garden2.AddRandomTrees(10, 10, 10);

            Console.WriteLine($"Garden 1: {garden1}");
            Console.WriteLine($"Garden 2: {garden2}");

            Console.WriteLine($"Garden 1 fence length: {garden1.GetFenceLength()}");
            Console.WriteLine($"Garden 2 fence length: {garden2.GetFenceLength()}");

            if (garden1 < garden2)
            {
                Console.WriteLine("Garden 1 has shorter fence than garden 2.");
            }
            else if (garden1 > garden2)
            {
                Console.WriteLine("Garden 2 has shorter fence than garden 1.");
            }
            else
            {
                Console.WriteLine("Both gardens have the same fence length.");
            }
        }
    }
}

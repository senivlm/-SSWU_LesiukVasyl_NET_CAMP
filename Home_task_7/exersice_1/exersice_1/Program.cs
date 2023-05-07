namespace exersice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Натисніть будь-яку клавішу для запуску світлофора.");
            Console.ReadKey();
            Console.Clear();
            TrafficController controller = new TrafficController();
            controller.Run();

            Console.ReadKey();
        }
    }
}
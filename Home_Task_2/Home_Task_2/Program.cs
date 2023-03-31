namespace Home_Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Simulator simulator = new Simulator(200, 100, 2, 3, "Vasya", 50);
            simulator.Start();
        }
    }
}
namespace exersice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tensor tensor = new Tensor(2, 5); // Створення тензора розміром 2x5
            tensor.FillRandomInt(0,11); // заповнення рандомними значеннями
            tensor.SetValue(22, 0, 4); // встановлення конкретного значення по індексах
            Console.WriteLine(tensor); // вивід
            Console.WriteLine(tensor.GetValue(0,4)); //вивід значення за індексами
        }
    }
}
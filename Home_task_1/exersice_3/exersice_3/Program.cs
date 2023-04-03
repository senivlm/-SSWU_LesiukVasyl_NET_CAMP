namespace exersice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Cube cube = new Cube(3);
            cube.AddHole(0, 0, 0);
            cube.AddHole(0, 1, 0);
            cube.AddHole(0, 2, 0);

            if (cube.CheckHole(out var start, out var end))
            {
                Console.WriteLine($"Є отвір від ({start.x1}, {start.y1}, {start.z1}) до ({end.x2}, {end.y2}, {end.z2})");
            }
            else
            {
                Console.WriteLine("Немає отвору");
            }
            Console.WriteLine(cube);
        }
    }
}
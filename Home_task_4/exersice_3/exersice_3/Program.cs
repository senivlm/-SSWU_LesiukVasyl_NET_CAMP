namespace exersice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "electricity_data.txt";

            Electricity electricity = new Electricity();
            electricity.ReadDataFromFile(fileName);

            // Set the price per KW
            electricity.PricePerKw = 0.15m;

            // Get the report
            Console.WriteLine("Electricity report:");
            Console.WriteLine(electricity);

            // Get the owner with the largest debt
            Console.WriteLine($"The owner with the largest debt is: {electricity.GetOwnerWithLargestDebt()}");

            // Get the apartments with no electricity usage
            Console.WriteLine("Apartments with no electricity usage:");
            var apartmentsWithNoUsage = electricity.GetApartmentsWithNoElectricityUsage();
            if (apartmentsWithNoUsage.Count == 0)
            {
                Console.WriteLine("No apartments found with no electricity usage.");
            }
            else
            {
                Console.WriteLine(string.Join(", ", apartmentsWithNoUsage));
            }

            Console.ReadLine();
        }
    }
}
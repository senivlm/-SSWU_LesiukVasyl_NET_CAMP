namespace Home_Task_2
{
    class Simulator
    {
        private readonly WaterTower tower;
        private readonly Pump pump;
        private readonly User user;

        public Simulator(int maxVolume,int currentVolume, int pumpPower, int pumpSpeed, string userName, double waterIntention)
        {
            tower = new WaterTower(maxVolume, currentVolume);
            pump = new Pump(pumpPower, pumpSpeed);
            user = new User(userName, waterIntention);
        }

        public void Start()
        {
            Console.WriteLine("Симулятор починає роботу...");

            // Початкова ініціалізація насоса
            pump.TurnOn();

            while (true)
            {
                Console.WriteLine("\nСтан системи:");

                Console.WriteLine("Водонапірна вежа:");
                Console.WriteLine($"Поточний об'єм води: {tower.CurrentVolume}");
                Console.WriteLine($"Максимальний об'єм води: {tower.MaxVolume}");

                Console.WriteLine("Користувач:");
                Console.WriteLine($"Намір на використання води: {user.WaterIntention}");

                Console.WriteLine("Насос:");
                Console.WriteLine($"Стан: {(pump.IsOn ? "увімкнений" : "вимкнений")}");
                Console.WriteLine($"Потужність: {pump.Power}");
                Console.WriteLine($"Швидкість качання води: {pump.Rate}");

                // Перевірка, чи є в вежі достатньо води для задуманої користувачем дії
                if (tower.CurrentVolume >= user.WaterIntention)
                {
                    Console.WriteLine("Користувач бере воду...");

                    tower.TakeWater(user.WaterIntention, pump);
                }
                else
                {
                    Console.WriteLine("Вода закінчилась, запускаємо насос...");

                    // Качаємо воду за допомогою насоса, доки не наберемо достатню кількість
                    while (tower.CurrentVolume < user.WaterIntention)
                    {
                        tower.AddWater(200);
                    }

                    Console.WriteLine("Вода набрана, зупиняємо насос...");

                    pump.TurnOff();
                }

                Console.WriteLine("Натисніть Enter, щоб продовжити або будь-яку іншу клавішу, щоб завершити...");
                if (Console.ReadKey(true).Key != ConsoleKey.Enter)
                {
                    break;
                }
            }
        }
    }
}

namespace Home_Task_2
{
    public class User
    {
        private string _name;
        private double _waterIntention;

        public User(string name, double waterIntention)
        {
            Name = name;
            WaterIntention = waterIntention;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double WaterIntention
        {
            get { return _waterIntention; }
            set
            {
                // Перевірка, щоб кількість води була більше 0
                if (value <= 0)
                {
                    Console.WriteLine("Помилка! Кількість води повинна бути більше 0. Значення буде встановлено за замовчуванням - 1 л.");
                    _waterIntention = 1;
                }
                else
                {
                    _waterIntention = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Користувач {Name}, Потрібно води: {WaterIntention:F2} л";
        }
    }
}

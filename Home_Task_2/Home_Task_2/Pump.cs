namespace Home_Task_2
{
    public class Pump
    {
        private int _power; // потужність насоса
        private int _rate; // швидкість набору води
        private bool _isOn; // стан насоса (включений/виключений)
        public Pump(int power, int rate)
        {
            Power = power;
            Rate = rate;
            _isOn = false;
        }

        public int Power
        {
            get { return _power; }
            set
            {
                if (value <= 0) // валідація: потужність повинна бути більше 0
                {
                    throw new ArgumentOutOfRangeException("Потужність повинна бути більше 0");
                }
                _power = value;
            }
        }

        public int Rate
        {
            get { return _rate; }
            set
            {
                if (value <= 0) // валідація: швидкість повинна бути більше 0
                {
                    throw new ArgumentOutOfRangeException("Швидкість повинна бути більше 0");
                }
                _rate = value;
            }
        }

        public bool IsOn
        {
            get { return _isOn; }
        }

        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Насос включений");
        }

        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Насос виключений");
        }

        public void PumpWater(WaterTower tower)
        {
            Console.WriteLine("Вода надходить в вежу зі швидкістю {0} л/с", _rate);
        }
    }
}

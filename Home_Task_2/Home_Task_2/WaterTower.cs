namespace Home_Task_2
{
    public class WaterTower
    {
        private double _maxVolume;
        private double _currentVolume;

        public double CurrentVolume
        {
            get { return _currentVolume; }
            internal set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Поточний об'єм не може бути від'ємним.");
                }
                else if (value > MaxVolume)
                {
                    throw new ArgumentException("Поточний об'єм не може перевищувати максимальний.");
                }

                _currentVolume = value;
            }
        }

        public double MaxVolume
        {
            get { return _maxVolume; }
            internal set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Максимальний об'єм не може бути від'ємним.");
                }
                else if (value < CurrentVolume)
                {
                    throw new ArgumentException("Максимальний об'єм не може бути меншим за поточний.");
                }

                _maxVolume = value;
            }
        }

        public WaterTower(double maxVolume, double currentVolume)
        {
            MaxVolume = maxVolume;
            CurrentVolume = currentVolume;
        }

        public void AddWater(double volume)
        {
            CurrentVolume += volume;
            if (CurrentVolume > MaxVolume)
            {
                CurrentVolume = MaxVolume;
                Console.WriteLine("Зайва вода була видалена.");
            }
        }

        public void TakeWater(double volume, Pump pump)
        {
            CurrentVolume -= volume;
            if (CurrentVolume < 0)
            {
                Console.WriteLine("Вода закінчилася. Насос увімкнено.");
                CurrentVolume = 0;
                pump.TurnOn();
            }
        }

        public override string ToString()
        {
            return string.Format("Максимальний об'єм: {0}\nПоточний об'єм: {1}", MaxVolume, CurrentVolume);
        }
    }
}

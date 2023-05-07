using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_1
{
    public class TrafficLight
    {
        public string Name { get; private set; }
        public ConsoleColor Color { get; private set; }
        private Timer timer;

        public event EventHandler<TrafficLightEventArgs> StateChanged;

        public TrafficLight(string name, ConsoleColor color)
        {
            this.Name = name;
            this.Color = color;
            this.timer = new Timer(OnTimerElapsed, null, Timeout.Infinite, Timeout.Infinite);
        }

        public void Start(int greenLightDuration, int yellowLightDuration, int redLightDuration)
        {
            this.timer.Change(0, Timeout.Infinite);
            Thread.Sleep(greenLightDuration * 1000);
            this.Color = ConsoleColor.Yellow;
            StateChanged?.Invoke(this, new TrafficLightEventArgs(this.Name, this.Color));
            Thread.Sleep(yellowLightDuration * 1000);
            this.Color = ConsoleColor.Red;
            StateChanged?.Invoke(this, new TrafficLightEventArgs(this.Name, this.Color));
            Thread.Sleep(redLightDuration * 1000);
            this.Color = ConsoleColor.Green;
            Start(greenLightDuration, yellowLightDuration, redLightDuration);
        }

        private void OnTimerElapsed(object state)
        {
            StateChanged?.Invoke(this, new TrafficLightEventArgs(this.Name, this.Color));
        }
    }
}

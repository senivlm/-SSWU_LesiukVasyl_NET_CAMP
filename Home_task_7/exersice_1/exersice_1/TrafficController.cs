using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_1
{
    public class TrafficController
    {
        private TrafficLight northSouth;
        private TrafficLight southNorth;
        private TrafficLight eastWest;
        private TrafficLight westEast;

        public TrafficController()
        {
            this.northSouth = new TrafficLight("Північ-південь", ConsoleColor.Green);
            this.southNorth = new TrafficLight("Південь-північ", ConsoleColor.Green);
            this.eastWest = new TrafficLight("Схід-захід", ConsoleColor.Red);
            this.westEast = new TrafficLight("Захід-схід", ConsoleColor.Red);

            this.northSouth.StateChanged += OnStateChanged;
            this.southNorth.StateChanged += OnStateChanged;
            this.eastWest.StateChanged += OnStateChanged;
            this.westEast.StateChanged += OnStateChanged;
        }

        private void OnStateChanged(object sender, TrafficLightEventArgs e)
        {
            Console.Clear();
            Console.WriteLine($"t={DateTime.Now.Second} с.");
            Console.WriteLine("Світлофор   Північ-південь   Південь-північ   Схід-захід   Захід-схід");
            Console.WriteLine($"Колір\t  {northSouth.Color}\t\t  {southNorth.Color}\t\t{eastWest.Color}\t  {westEast.Color}");
        }
        public void Run()
        {
            while (true)
            {
                northSouth.Start(10, 2, 10);
                eastWest.Start(5, 2, 5);
                southNorth.Start(10, 2, 10);
                westEast.Start(5, 2, 5);
            }
        }
    }
}

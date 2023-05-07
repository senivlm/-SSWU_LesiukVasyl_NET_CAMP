using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_1
{
    public class TrafficLightEventArgs : EventArgs
    {
        public string Name { get; private set; }
        public ConsoleColor Color { get; private set; }

        public TrafficLightEventArgs(string name, ConsoleColor color)
        {
            this.Name = name;
            this.Color = color;
        }
    }
}

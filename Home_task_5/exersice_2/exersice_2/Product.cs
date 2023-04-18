using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_2
{
    class Product
    {
        private string name;
        private double height, width, length;

        public Product(string name, double height, double width, double length)
        {
            this.name = name;
            this.height = height;
            this.width = width;
            this.length = length;
        }

        public string Name { get { return name; } }
        public double Height { get { return height; } }
        public double Width { get { return width; } }
        public double Length { get { return length; } }
    }
}

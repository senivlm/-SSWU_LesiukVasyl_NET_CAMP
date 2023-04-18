using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_2
{
    class Box
    {
        private string name;
        private double height, width, length;
        private List<Box> boxes;

        public Box(string name)
        {
            this.name = name;
            this.boxes = new List<Box>();
        }
        public Box(string name, double height, double width, double length)
        {
            this.name = name;
            this.boxes = new List<Box>();
            this.height = height;
            this.width = width;
            this.length = length;
        }

        public string Name { get { return name; } }
        public double Height { get { return height; } }
        public double Width { get { return width; } }
        public double Length { get { return length; } }

        public void SetDimensions(double height, double width, double length)
        {
            this.height = height;
            this.width = width;
            this.length = length;
        }

        public void AddBox(Box box)
        {
            boxes.Add(box);
        }

        public List<Box> GetBoxes()
        {
            return boxes;
        }

        public bool IsEmpty()
        {
            return boxes.Count == 0;
        }
    }
}

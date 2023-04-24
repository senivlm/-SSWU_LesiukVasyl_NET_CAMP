using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace exersice_1
{// треба було вибудовувати опуклу оболонку. ЇЇ периметр і буде оптимальним
    class Garden
    {
        private List<Tree> trees;

        public Garden()
        {
            trees = new List<Tree>();
        }

        public void AddTree(double x, double y)
        {
            trees.Add(new Tree(x, y));
        }

        public void AddRandomTrees(int count, double maxX, double maxY)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                double x = rnd.NextDouble() * maxX;
                double y = rnd.NextDouble() * maxY;
                AddTree(x, y);
            }
        }

        public double GetFenceLength()
        {
            double fenceLength = 0;

            double minX = double.MaxValue;
            double maxX = double.MinValue;
            double minY = double.MaxValue;
            double maxY = double.MinValue;
            foreach (Tree tree in trees)
            {
                minX = Math.Min(minX, tree.X);
                maxX = Math.Max(maxX, tree.X);
                minY = Math.Min(minY, tree.Y);
                maxY = Math.Max(maxY, tree.Y);
            }

            double width = maxX - minX;
            double height = maxY - minY;
            double fenceWidth = width + 2 * height;
            double fenceHeight = height + 2 * width;
            if (fenceWidth < fenceHeight && fenceWidth < Math.Sqrt(width * width + height * height))
            {
                fenceLength = fenceWidth;
            }
            else if (fenceHeight < Math.Sqrt(width * width + height * height))
            {
                fenceLength = fenceHeight;
            }
            else
            {
                fenceLength = Math.Sqrt(width * width + height * height);
            }

            return fenceLength;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Tree tree in trees)
            {
                sb.Append(tree.ToString());
                sb.Append(" ");
            }

            return sb.ToString();
        }

        public static bool operator <(Garden garden1, Garden garden2)
        {
            return garden1.GetFenceLength() < garden2.GetFenceLength();
        }

        public static bool operator >(Garden garden1, Garden garden2)
        {
            return garden1.GetFenceLength() > garden2.GetFenceLength();
        }

    }
}

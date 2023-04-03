using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_3
{
    public class Cube
    {
        private readonly bool[,,] cube;
        private readonly int size;

        public Cube(int size)
        {
            this.size = size;
            cube = new bool[size, size, size];
        }

        public void AddHole(int x, int y, int z)
        {
            cube[x, y, z] = true;
        }

        public bool CheckHole(out (int x1, int y1, int z1) start, out (int x2, int y2, int z2) end)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (CheckLine(i, j, 0, 0, 0, 1))
                    {
                        start = (i, j, 0);
                        end = (i, j, size - 1);
                        return true;
                    }
                    if (CheckLine(i, 0, j, 0, 1, 0))
                    {
                        start = (i, 0, j);
                        end = (i, size - 1, j);
                        return true;
                    }
                    if (CheckLine(0, i, j, 1, 0, 0))
                    {
                        start = (0, i, j);
                        end = (size - 1, i, j);
                        return true;
                    }
                }
            }
            start = (-1, -1, -1);
            end = (-1, -1, -1);
            return false;
        }
        private bool CheckLine(int xStart, int yStart, int zStart, int xStep, int yStep, int zStep)
        {
            for (int i = 0; i < size; i++)
            {
                if (!cube[xStart + xStep * i, yStart + yStep * i, zStart + zStep * i])
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int z = 0; z < size; z++)
            {
                for (int y = 0; y < size; y++)
                {
                    for (int x = 0; x < size; x++)
                    {
                        sb.Append(cube[x, y, z] ? "O" : "X");
                    }
                    sb.AppendLine();
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
 }

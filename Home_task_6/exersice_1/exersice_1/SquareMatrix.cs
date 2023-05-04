using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_1
{
    class SquareMatrix : IEnumerable<int>
    {
        private readonly int[,] matrix;
        private readonly int size;

        public SquareMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (rows != columns)
            {
                throw new ArgumentException("The matrix must be square.");
            }

            this.matrix = matrix;
            size = rows;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int row = 0, col = 0;
            bool directionDown = true;

            while (row < size && col < size)
            {
                yield return matrix[row, col];
// не оптимально кожного елемента питати, чи він не останній, або перший.
                if (directionDown)
                {
                    if (row == size - 1)
                    {
                        directionDown = false;
                        col++;
                    }
                    else if (col == 0)
                    {
                        directionDown = false;
                        row++;
                    }
                    else
                    {
                        row++;
                        col--;
                    }
                }
                else
                {
                    if (col == size - 1)
                    {
                        directionDown = true;
                        row++;
                    }
                    else if (row == 0)
                    {
                        directionDown = true;
                        col++;
                    }
                    else
                    {
                        row--;
                        col++;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int element in this)
            {
                sb.Append(element);
                sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}

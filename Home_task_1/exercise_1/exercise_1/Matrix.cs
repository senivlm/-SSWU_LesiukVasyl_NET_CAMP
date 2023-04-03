using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    public class Matrix
    {
        private readonly int[,] _matrix;
        private readonly int _rows;
        private readonly int _columns;

        public Matrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _matrix = new int[rows, columns];
        }
        public void FillSpiral()
        {
            int value = 1;
            int left = 0;
            int top = 0;
            int right = _columns - 1;
            int bottom = _rows - 1;

            while (left <= right && top <= bottom)
            {
                for (int i = top; i <= bottom; i++)
                {
                    _matrix[i, left] = value;
                    value++;
                }
                left++;

                for (int i = left; i <= right; i++)
                {
                    _matrix[bottom, i] = value;
                    value++;
                }
                bottom--;

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        _matrix[i, right] = value;
                        value++;
                    }
                    right--;
                }

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        _matrix[top, i] = value;
                        value++;
                    }
                    top++;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    sb.Append(_matrix[i, j] + "\t");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    public class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int cols;
        private Random random = new Random();

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new int[rows, cols];
            FillMatrix(17);
        }

        public void FillMatrix(int max)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(max);
                }
            }
        }

        public (int maxColor, int maxLength, int startRow, int startCol, int endRow, int endCol) FindLongestHorizontalLine()
        {
            int maxColor = -1;
            int maxLength = 0;
            int startRow = -1;
            int startCol = -1;
            int endRow = -1;
            int endCol = -1;

            for (int i = 0; i < rows; i++)
            {
                int currentColor = matrix[i, 0];
                int currentLength = 1;
                int currentStartCol = 0;

                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] == currentColor)
                    {
                        currentLength++;
                    }
                    else
                    {
                        if (currentLength > maxLength)
                        {
                            maxColor = currentColor;
                            maxLength = currentLength;
                            startRow = i;
                            startCol = currentStartCol;
                            endRow = i;
                            endCol = j - 1;
                        }

                        currentColor = matrix[i, j];
                        currentLength = 1;
                        currentStartCol = j;
                    }
                }

                if (currentLength > maxLength)
                {
                    maxColor = currentColor;
                    maxLength = currentLength;
                    startRow = i;
                    startCol = currentStartCol;
                    endRow = i;
                    endCol = cols - 1;
                }
            }

            return (maxColor, maxLength, startRow, startCol, endRow, endCol);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(matrix[i, j] + "\t");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

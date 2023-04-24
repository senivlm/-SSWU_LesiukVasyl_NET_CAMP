using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exersice_4
{// ідея правильна, але трішки не докінчена. ви не можете тензору присвоїти будь-який масив.
    public class Tensor
    {
        private readonly int[] _shape;
        private readonly int[] _data;

        public Tensor(params int[] shape)
        {
            _shape = shape;
            _data = new int[CalculateSize()];
        }

        private int CalculateSize()
        {
            int size = 1;

            foreach (int dim in _shape)
            {
                size *= dim;
            }

            return size;
        }

        public double GetValue(params int[] indices)
        {
            int index = CalculateIndex(indices);
            return _data[index];
        }

        public void SetValue(int value, params int[] indices)
        {
            int index = CalculateIndex(indices);
            _data[index] = value;
        }

        private int CalculateIndex(params int[] indices)
        {
            if (indices.Length != _shape.Length)
            {
                throw new ArgumentException("Кількість індексів повинна відповідати рангу тензора");
            }

            int index = 0;
            int multiplier = 1;

            for (int i = _shape.Length - 1; i >= 0; i--)
            {
                int ind = indices[i];

                if (ind < 0 || ind >= _shape[i])
                {
                    throw new ArgumentException("Індекс поза межами діапазону");
                }

                index += multiplier * ind;
                multiplier *= _shape[i];
            }

            return index;
        }

        public void FillRandomInt(int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < _data.Length; i++)
            {
                _data[i] = rand.Next(min, max);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Тензор:");
            sb.AppendLine($"Ранг: {_shape.Length}");
            sb.Append("Розмірність: [");
            for (int i = 0; i < _shape.Length; i++)
            {
                sb.Append(_shape[i]);
                if (i != _shape.Length - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.AppendLine("]");

            sb.Append("Данні: [");
            for (int i = 0; i < _data.Length; i++)
            {
                sb.Append(_data[i]);

                if (i != _data.Length - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("]");

            return sb.ToString();
        }
    }
}

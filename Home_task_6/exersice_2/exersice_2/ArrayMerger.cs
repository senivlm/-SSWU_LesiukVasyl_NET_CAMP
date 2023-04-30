using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exersice_2
{
    public class ArrayMerger
    {
        private readonly int[][] arrays;

    public ArrayMerger(params int[][] arrays)
    {
        this.arrays = arrays;
    }

    public IEnumerable<int> MergeAndSort()
    {
        List<int> result = new List<int>();
        foreach (var array in arrays)
        {
            result.AddRange(array);
        }
        result.Sort();
        foreach (var item in result)
        {
            yield return item;
        }
    }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var array in arrays)
            {
                sb.Append("[");
                for (int i = 0; i < array.Length; i++)
                {
                    sb.Append(array[i]);
                    if (i < array.Length - 1)
                    {
                        sb.Append(", ");
                    }
                }
                sb.Append("]");
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.Custom_Sort_Demo
{
    public class SortClass
    {
        public static T[] Sort<T>(T[] array, Func<T, T, int> comp)
        {
            var result = new T[array.Length];
            array.CopyTo(result, 0);

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (comp?.Invoke(result[i], result[j]) == 1)
                    {
                        Swap(ref result[i], ref result[j]);
                    }
                }
            }

            return result;
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.Number_Array_Sum
{
    public static class IntegerArray
    {
        public static int Sum(this int[] arr)
        {
            int result = new int();

            foreach (var item in arr)
            {
                result += item;
            }

            return result;
        }

        public static double Sum(this double[] arr)
        {
            double result = new double();

            foreach (var item in arr)
            {
                result += item;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.Custom_Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 7, 2, 6, 7, -1, 67, 8, 1, 5, 2 };

            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Func<int, int, int> compare = CompareNumbers;

            int[] result = SortClass.Sort<int>(arr, 0, arr.Length - 1, compare);

            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static int CompareNumbers(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private int MySort(string a, string b)
        {
            return 1;
        }
    }
}

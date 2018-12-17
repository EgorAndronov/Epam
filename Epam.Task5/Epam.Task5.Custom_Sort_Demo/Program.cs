using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task5;

namespace Epam.Task5.Custom_Sort_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] strArr = new string[] { "bcds", "adcasd", "abcbb", "cbdwqeq", "ca", "ac", "bc", "abcd" };

            foreach (var item in strArr)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Func<string, string, int> compare = CompareString;

            string[] result = SortClass.Sort<string>(strArr, compare);

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

        private static int CompareString(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return 1;
            }
            else if (a.Length < b.Length)
            {
                return -1;
            }
            else
            {
                return a.CompareTo(b);
            }
        }
    }
}

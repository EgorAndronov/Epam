using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.I_Seek_You
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { -1, 3, -5, 2, 6, -10, 0, 3, 1 };

            Console.WriteLine("Direct search:");
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            List<int> result1 = PositiveNumbers(array);
            stopwatch1.Stop();
            
            foreach (var item in result1)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Time:");
            Console.WriteLine(stopwatch1.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Search through the delegate:");

            Func<int, bool> compare = Compare;
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            List<int> result2 = PositiveNumbers(array, compare);
            stopwatch2.Stop();
            foreach (var item in result2)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Time:");
            Console.WriteLine(stopwatch2.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Search through the anonim delegate:");
            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            List<int> result3 = PositiveNumbers(array, delegate(int x) { return x > 0; });
            stopwatch3.Stop();
            foreach (var item in result3)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Time:");
            Console.WriteLine(stopwatch3.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Search through the => delegate:");
            Stopwatch stopwatch4 = new Stopwatch();
            stopwatch4.Start();
            List<int> result4 = PositiveNumbers(array, (x) => x > 0);
            stopwatch4.Stop();
            foreach (var item in result4)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Time:");
            Console.WriteLine(stopwatch4.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Search through LinQ:");
            Stopwatch stopwatch5 = new Stopwatch();
            stopwatch5.Start();
            int[] result5 = GetPositive(array);
            stopwatch5.Stop();
            foreach (var item in result5)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Time:");
            Console.WriteLine(stopwatch5.Elapsed);
            Console.WriteLine();
        }

        private static List<int> PositiveNumbers(int[] arr)
        {
            List<int> result = new List<int>();

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        private static bool Compare(int a)
        {
            return a > 0;
        }

        private static List<int> PositiveNumbers(int[] arr, Func<int, bool> comp)
        {
            List<int> result = new List<int>();

            foreach (var item in arr)
            {
                if (comp(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        private static int[] GetPositive(int[] arr)
        {
            var result = from item in arr
                         where item > 0
                         select item;
            return result.ToArray();
        }
    }
}

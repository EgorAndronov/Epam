using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task5.Sorting_Unit
{
    public class Program
    {
        public delegate void EndMethod();

        public static event EndMethod EndEvent;

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

            EndEvent = Message;

            SortThread<string>(strArr, compare);

            Thread.Sleep(300);
            foreach (var item in strArr)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Sort<T>(T[] array, Func<T, T, int> comp)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comp?.Invoke(array[i], array[j]) == 1)
                    { 
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }

            EndEvent();
        }

        public static void Message()
        {
            Console.WriteLine("End Sort");
        }

        public static void SortThread<T>(T[] array, Func<T, T, int> comp)
        {
            ThreadStart th1 = new ThreadStart(() => Sort(array, comp));
            Thread th = new Thread(th1);
            
            th.Start();
        }

        public static int CompareNumbers(int a, int b)
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

        public static int CompareString(string a, string b)
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

        private static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Dynamic_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<int> en = new List<int>();
                for (int i = 1; i <= 8; i++)
                {
                    en.Add(i);
                }

                DinamicArray<int> num = new DinamicArray<int>(en);

                Console.WriteLine("Sourse DinamicArray:");
                for (int i = 0; i < num.Count; i++)
                {
                    Console.WriteLine(num[i]);
                }

                num.Add(9);

                Console.WriteLine();
                Console.WriteLine("Result method \"Add\"");
                for (int i = 0; i < num.Count; i++)
                {
                    Console.WriteLine(num[i]);
                }

                Console.WriteLine();

                List<int> en1 = new List<int>();
                for (int i = 10; i <= 18; i++)
                {
                    en1.Add(i);
                }

                num.AddRange(en1);
                Console.WriteLine("Result method \"AddRange\"");
                for (int i = 0; i < num.Count; i++)
                {
                    Console.WriteLine(num[i]);
                }

                Console.WriteLine();

                Console.WriteLine("Result method \"Remove\"");
                Console.WriteLine(num.Remove(17));
                Console.WriteLine();
                for (int i = 0; i < num.Count; i++)
                {
                    Console.WriteLine(num[i]);
                }

                Console.WriteLine();

                num.Insert(100, 17);
                Console.WriteLine("Result method \"Insert\"");
                for (int i = 0; i < num.Count; i++)
                {
                    Console.WriteLine(num[i]);
                }

                Console.WriteLine();

                Console.WriteLine("Length:");
                Console.WriteLine(num.Count);
                Console.WriteLine();
                Console.WriteLine("Capacity:");
                Console.WriteLine(num.Capacity);
                Console.WriteLine();

                Console.WriteLine("Foreach:");
                foreach (var item in num)
                {
                    Console.Write($"{item}, ");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Negative index:");
                Console.WriteLine(num[-15]);

                Console.WriteLine();
                Console.WriteLine("New Capacity");
                num.Capacity = 7;
                foreach (var item in num)
                {
                    Console.Write($"{item}, ");
                }

                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Clone:");
                var numClone = (DinamicArray<int>)num.Clone();

                foreach (var item in numClone)
                {
                    Console.Write($"{item}, ");
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("ToArray:");
                var arr = num.ToArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]}, ");
                }

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

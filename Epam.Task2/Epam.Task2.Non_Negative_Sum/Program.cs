using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Non_Negative_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма неотрицательных элементов массива = {SumPos(array)}");
        }

        static int SumPos(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                if (item > 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

    }
}

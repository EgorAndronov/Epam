using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Array2D
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] array = new int[5, 5];

            Random rnd = new Random();

            Console.WriteLine("Source array:");
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    Console.Write($"{array[i,j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of the elements on the even positions = {Sum(array)}");
        }

        private static int Sum(int[,] array)
        {
            int sum = 0;

            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    if ((j != 0 || i != 0) && ((i + j) % 2 == 0))
                    {
                        sum += array[i, j];
                    }
                }
            }

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.No_Positive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,,] array = new int[2, 3, 5];
            Random rnd = new Random();

            Console.WriteLine("Source array:");
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    for (int k = array.GetLowerBound(2); k <= array.GetUpperBound(2); k++)
                    { 
                        array[i, j, k] = rnd.Next(-10, 10);
                        Console.Write($"{array[i,j,k]} ");
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("New array:");
            ReplacePos(ref array);
        }

        private static void ReplacePos(ref int[,,] array)
        {
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    for (int k = array.GetLowerBound(2); k <= array.GetUpperBound(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }

                        Console.Write($"{array[i, j, k]} ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

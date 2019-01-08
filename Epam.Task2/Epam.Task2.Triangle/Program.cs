using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = new int();
            Console.WriteLine("Enter positive integer number: ");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                ShowTriangle(num);
            }
            else
            {
                Console.WriteLine($"Entered not number");
            }
        }

        private static void ShowTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}

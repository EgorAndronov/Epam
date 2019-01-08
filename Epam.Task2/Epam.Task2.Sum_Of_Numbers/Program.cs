using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Sum_Of_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 1000;
            Console.WriteLine($"The sum of all positive integers is less than 1000 and a multiple of 3 or 5 = {Sum(num)}");
        }

        private static int Sum(int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}

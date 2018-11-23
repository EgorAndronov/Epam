using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Sum_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1000;
            Console.WriteLine($"Сумма всех натуральных чисел меньше 1000 и кратных 3 или 5 = {Sum(num)}");
        }

        static int Sum(int n)
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

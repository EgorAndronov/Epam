using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            FunctionSimple(number);
        }

        static void FunctionSimple (int N)
        {
            bool flag = true;
            //Для проверки, достаточно искать делители до квадратного корня числа. Это уменьшит время выполнения.
            for (int i = 2; i <= (int)Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Число является простым");
            }
            else
            {
                Console.WriteLine("Число является составным");
            }
        }
    }
}

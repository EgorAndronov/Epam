using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int number=0;
            while (flag)
            {
                Console.WriteLine("Введите положительное нечетное число");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Вы ввели четное число");
                }

                else if (number <= 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число");
                }

                else
                {
                    flag = false;
                }
                
            }
            FunctionSquare(number);
        }

        static void FunctionSquare(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j == ((N-1)/2) && i == ((N-1)/2))
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

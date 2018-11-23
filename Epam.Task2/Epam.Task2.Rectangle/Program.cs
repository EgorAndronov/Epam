using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a;
                int b;
                Console.WriteLine("Введите сторону a (Целое положительное число): ");
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    if (a < 0)
                    {
                        Console.WriteLine("Число не может быть отрицательным, введите значение заново");
                    }
                    else if (a == 0)
                    {
                        Console.WriteLine("Число не может быть равно 0, введите значение заново");
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Введите сторону b (Целое положительное число): ");
                            if (int.TryParse(Console.ReadLine(), out b))
                            {
                                if (b < 0)
                                {
                                    Console.WriteLine("Число не может быть отрицательным, введите значение заново");
                                }
                                else if (b == 0)
                                {
                                    Console.WriteLine("Число не может быть равно 0, введите значение заново");
                                }
                                else
                                {
                                    Console.WriteLine($"Площадь прямоугольника = {Fun(a, b)}");
                                    break;
                                }
                            }
                        }
                        break;
                    }

                }

            }
        }

        static int Fun(int a, int b)
        {
            return a * b;
        }

    }
}

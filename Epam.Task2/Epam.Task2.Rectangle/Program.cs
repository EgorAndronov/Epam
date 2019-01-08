using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Rectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter side \"a\" (Positive integer): ");

                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    if (a < 0)
                    {
                        Console.WriteLine("Number is negative");
                    }
                    else if (a == 0)
                    {
                        Console.WriteLine("Number = 0");
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter side \"b\" (Positive integer): ");

                            if (int.TryParse(Console.ReadLine(), out int b))
                            {
                                if (b < 0)
                                {
                                    Console.WriteLine("Number is negative");
                                }
                                else if (b == 0)
                                {
                                    Console.WriteLine("Number = 0");
                                }
                                else
                                {
                                    Console.WriteLine($"Area of rectangle = {Fun(a, b)}");
                                    break;
                                }
                            }
                        }

                        break;
                    }
                }
            }
        }

        private static int Fun(int a, int b)
        {
            return a * b;
        }
    }
}

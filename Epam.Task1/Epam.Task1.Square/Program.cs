using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            int number = 0;

            while (flag)
            {
                Console.WriteLine("Enter positive uneven number ");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Entered even number");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Entered negative number");
                }
                else
                {
                    flag = false;
                }
            }

            FunctionSquare(number);
        }

        private static void FunctionSquare(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == ((n - 1) / 2) && i == ((n - 1) / 2))
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

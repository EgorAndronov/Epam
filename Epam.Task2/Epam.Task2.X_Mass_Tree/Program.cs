using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.X_Mass_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = new int();
            while (true)
            {
                Console.WriteLine("Введите целое положительно число: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    ShowTriangle(num);
                    break;
                }
                else
                {
                    Console.WriteLine("Введено не число");
                }

            }
        }

        static void ShowTriangle(int n)
        {
            for (int k = 1; k <= n; k++)
            {
                for (int i = 1; i <= k; i++)
                {

                    for (int g = 0; g < n - i; g++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = 1; j <= (i * 2) - 1; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}

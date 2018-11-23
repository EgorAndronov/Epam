using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = new int();
            Console.WriteLine("Введите целое положительно число: ");
            if(int.TryParse(Console.ReadLine(), out num))
            {
                ShowTriangle(num);
            }
            else
            {
                Console.WriteLine("Введено не число");
            }
            
        }

        static void ShowTriangle(int n)
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

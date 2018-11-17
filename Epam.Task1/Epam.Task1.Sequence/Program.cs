using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FunctionSequence(number)); 
            
        }

        public static string FunctionSequence(int N)
        {
            int[] mass = new int[N];
            for (int i = 1; i <= N; i++)
            {
                mass[i - 1] = i;
            }
            return String.Join(", ", mass);
        }
    }

   
}

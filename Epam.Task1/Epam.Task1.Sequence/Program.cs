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
            
            String str = "";
            for (int i = 1; i < N; i++)
            {
                str += i + ", ";
            }
            str += N;
            return str;
        }
    }

   
}

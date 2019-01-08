using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            FunctionSimple(number);

            if (FunctionSimple(number))
            {
                Console.WriteLine($"\"{number}\" is simple number");
            }
            else
            {
                Console.WriteLine($"\"{number}\" is composite number");
            }
        }

        private static bool FunctionSimple(int n)
        {
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

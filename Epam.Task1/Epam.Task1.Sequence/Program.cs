using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FunctionSequence(number)); 
        }

        public static string FunctionSequence(int n)
        {
            string str = string.Empty;
            for (int i = 1; i < n; i++)
            {
                str += i + ", ";
            }

            str += n;
            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter sides:");
            Console.Write("a: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Not integer value");
            }

            Console.Write("b: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Not integer value");
            }

            Console.Write("c: ");
            if (!int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine("Not integer value");
            }

            Triangle triangle = new Triangle(a, b, c);
            triangle.Display();            
        }
    }
}

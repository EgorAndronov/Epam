using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Round
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of center:");
            Console.Write("x: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Not integer value");
            }

            Console.Write("y: ");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Not integer value");
            }

            Console.Write("Enter radius: ");
            if (!int.TryParse(Console.ReadLine(), out int r))
            {
                Console.WriteLine("Not real value");
            }

            Round round = new Round(new int[] { x, y }, r);
            
            round.Display();
        }
    }
}

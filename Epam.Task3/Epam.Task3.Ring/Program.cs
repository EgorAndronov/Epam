using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ring myRing = new Ring(10, 20);

            Console.WriteLine(myRing.Square);
        }
    }
}

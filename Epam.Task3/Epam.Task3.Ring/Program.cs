using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Ring myRing = new Ring(10, 20);

            Console.WriteLine($"Ring: inner radius = {myRing.InnerRadius}, outer radius = {myRing.OuterRadius}, area = {myRing.Area}, sum of length = {myRing.SumLength}");
        }
    }
}

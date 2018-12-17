using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.To_Int_Or_Not_To_Int
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "+4,684666666666e12";

            Console.WriteLine(str.IsPositiveInteger());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.Time_Counter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter text");
                var text = Console.ReadLine();

                var regexPat = @"\b((0?[0-9])|(1[0-9])|(2[0-3])):[0-5][0-9]\b";
                var regex = new Regex(regexPat);

                Console.WriteLine();
                Console.WriteLine("Time in the text");

                foreach (var item in regex.Matches(text))
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

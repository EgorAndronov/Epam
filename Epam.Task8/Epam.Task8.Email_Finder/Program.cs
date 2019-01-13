using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.Email_Finder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter text");
                var text = Console.ReadLine();
                var regexPat = @"\b[a-z0-9][\w.-]+[a-z0-9]@([a-z0-9][a-z0-9-]+[a-z0-9]\.)+[a-z0-9]{2,6}\b";
                var regex = new Regex(regexPat);
                Console.WriteLine();
                Console.WriteLine("Emails:");
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

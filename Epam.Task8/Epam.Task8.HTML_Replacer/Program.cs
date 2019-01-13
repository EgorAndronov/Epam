using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.HTML_Replacer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter text");
                var text = Console.ReadLine();
                var regexPat = "<([a-z]*|[a-z]*.+?)>|</[a-z]*>|<[a-z]*/>";
                var stringReplace = "_";
                var regex = new Regex(regexPat);

                var result = regex.Replace(text, stringReplace);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

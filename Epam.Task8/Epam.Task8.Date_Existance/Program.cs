using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.Date_Existance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter text");
                var text = Console.ReadLine();
                var regexPat = @"\b((([0-2][0-9]|[3][01])-(0[13578]|([1][02])))|(([0-2][0-9]|30)-(0[469]|11))|([0-2][0-8]-02))-[0-9]{4}\b";
                var regex = new Regex(regexPat);
                if (regex.IsMatch(text))
                {
                    Console.WriteLine("Date is contained in this text.");
                }
                else
                {
                    Console.WriteLine("Date is not contained in this text.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

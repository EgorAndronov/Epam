using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8.Number_Validator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number");
                var text = Console.ReadLine();

                var regexNormalPat = @"^-?[0-9]+(.[0-9]+)?$";
                var regexSciencePat = @"^-?[0-9]+(.[0-9]+)?[eE][\-\+]?[0-9]+$";

                var regexNormal = new Regex(regexNormalPat);
                var regexScience = new Regex(regexSciencePat);

                if (regexNormal.IsMatch(text))
                {
                    Console.WriteLine("This number is in the usual form.");
                }
                else if (regexScience.IsMatch(text))
                {
                    Console.WriteLine("This number is in the scientific form.");
                }
                else
                {
                    Console.WriteLine("This is not a number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

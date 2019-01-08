using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Char_Doubler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine($"Enter second string: ");
            string str2 = Console.ReadLine();
            Console.WriteLine($"Result string: {StringDoubler(str1, str2)}");
        }

        private static string StringDoubler(string str1, string str2)
        {
            var strBuild1 = new StringBuilder(str1);
            var strBuild2 = new StringBuilder(str2);
            int i = 0;
            while (str2 != string.Empty)
            {
                if (str1.Contains(str2[i].ToString()))
                {            
                    str1 = str1.Replace(str2[i].ToString(), str2[i].ToString() + str2[i].ToString()); 
                }

                str2 = str2.Replace(str2[i].ToString(), string.Empty);
            }

            return str1;
        }
    }
}

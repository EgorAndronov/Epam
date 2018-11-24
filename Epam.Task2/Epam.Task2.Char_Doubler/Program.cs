using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Char_Doubler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine($"Введите первую строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine($"Введите вторую строку: ");
            string str2 = Console.ReadLine();
            Console.WriteLine($"Результрующая строка: {StringDoubler(str1, str2)}");
        }

        static string StringDoubler(string str1, string str2)
        {

            var strBuild1 = new StringBuilder(str1);
            var strBuild2 = new StringBuilder(str2);
            int i = 0;
            while (str2!="")
            {
                

                if (str1.Contains(str2[i].ToString()))
                {
                    
                    str1=str1.Replace(str2[i].ToString(), (str2[i].ToString() + str2[i].ToString()));
                    
                }
                str2 = str2.Replace(str2[i].ToString(), String.Empty);
            }
            


            return str1;
        }
    }
}

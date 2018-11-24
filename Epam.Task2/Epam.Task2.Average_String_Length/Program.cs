using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Average_String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = (Console.ReadLine());
            //string str = "Привет, я Егор Андронов";

            Console.WriteLine(WordAverageLength(str));




            //Console.WriteLine(Char.IsPunctuation(s));
        }

        static float WordAverageLength(string str)
        {
            
                string[] arrStr = str.Split(' ');
                float sum = 0f;

                for (int i = 0; i < arrStr.Length; i++)
                {
                    for (int j = 0; j < arrStr[i].Length; j++)
                    {
                        if (char.IsPunctuation(arrStr[i][j]))
                        {
                            arrStr[i] = arrStr[i].Remove(j);
                        }
                    }
                }

                foreach (var item in arrStr)
                {
                    sum += item.Length;
                }
            return sum / arrStr.Length;
        }
    }
}

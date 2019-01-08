using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Average_String_Length
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine(WordAverageLength(str));
        }

        private static float WordAverageLength(string str)
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

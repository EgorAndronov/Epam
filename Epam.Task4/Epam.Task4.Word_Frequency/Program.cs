using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Word_Frequency
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter text");

            string str = Console.ReadLine();

            List<string> resultList = StringToList(str);

            for (int i = 0; i < resultList.Count; i++)
            {
                Console.WriteLine($"Number of \"{resultList[i]}\" in the text = {StringFind(resultList, resultList[i])}");
               
                i--;
            }
        }

        private static int StringFind(List<string> strList, string str)
        {
            int num = 0;

            for (int i = 0; i < strList.Count; i++)
            {
                if (strList[i].Equals(str))
                {
                    num++;
                    strList.RemoveAt(i);
                    i--;
                }
            }

            return num;
        }

        private static List<string> StringToList(string str)
        {
            string[] strArray = str.Split(new char[] { ' ', '.' });
            List<string> stringList = new List<string>();

            foreach (var item in strArray)
            {
                stringList.Add(item);
            }

            for (int i = 0; i < stringList.Count; i++)
            {
                for (int j = 0; j < stringList[i].Length; j++)
                {
                    if (char.IsPunctuation(stringList[i][j]))
                    {
                        stringList[i] = stringList[i].Remove(stringList[i].IndexOf(stringList[i][j]));
                    }
                }

                stringList.RemoveAll(x => x == string.Empty);
            }

            return stringList;
        }
    }
}

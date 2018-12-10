using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Lost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number of people:");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    List<Person> listPerson = new List<Person>();
                    for (int i = 0; i < n; i++)
                    {
                        Person p = new Person(string.Format($"Name {i+1}"));
                        listPerson.Add(p);
                    }

                    foreach (var item in listPerson)
                    {
                        Console.WriteLine(item.Show());
                    }

                    Console.WriteLine();
                    while (listPerson.Count != 1)
                    {
                        int num = listPerson.Count;
                        for (int i = 1; i < listPerson.Count; i += 2)
                        {
                            listPerson.RemoveAt(i);
                            i--;
                        }

                        foreach (var item in listPerson)
                        {
                            Console.WriteLine(item.Show());
                        }
                        
                        Console.WriteLine();                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

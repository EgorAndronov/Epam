using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Employee
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter surName: ");
            string surname = Console.ReadLine();
            Console.Write("Enter firstName: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter patronymic: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            Console.Write("Year:");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("You entered not a number");
            }
            Console.Write("Month:");
            if (!int.TryParse(Console.ReadLine(), out int month))
            {
                Console.WriteLine("You entered not a number");
            }
            Console.Write("Day:");
            if (!int.TryParse(Console.ReadLine(), out int day))
            {
                Console.WriteLine("You entered not a number");
            }
            Console.Write("Work Experience:");
            if (!int.TryParse(Console.ReadLine(), out int workExp))
            {
                Console.WriteLine("You entered not a number");
            }
            Console.Write("Enter position: ");
            string posit = Console.ReadLine();

            DateTime dateOfBirth = new DateTime(year, month, day);
            Employee user = new Employee(surname, firstname, patronymic, dateOfBirth, workExp, posit);

            user.Display();
        }
    }
}

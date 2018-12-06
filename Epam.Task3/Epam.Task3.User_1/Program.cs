using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.User_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter surName: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter firstName: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter patronymic: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth: ");
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

            DateTime dateOfBirth = new DateTime(year, month, day);
            User user = new User(surname, firstname, patronymic, dateOfBirth);

            user.Display();
        }
    }
}

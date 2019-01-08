using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL.Interface;
using Epam.Task7.Common;

namespace Epam.Task7.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            var userLogic = Dependency.UserLogic;
            //NewUser("Егор Андроновыв", new DateTime(1996, 04, 05), userLogic);
            //NewUser("Вася Пупкин", new DateTime(1996, 01, 06), userLogic);
            //NewUser("Вася Лупкин", new DateTime(1996, 01, 04), userLogic);
            //NewUser("Петя", new DateTime(1996, 01, 05), userLogic);
            //NewUser("Юля", new DateTime(1996, 02, 03), userLogic);
            //NewUser("Коля", new DateTime(1991, 01, 05), userLogic);
            userLogic.Delete(3);
            ShowUsers(userLogic);
            userLogic.Save();
        }

        static void NewUser(string name, DateTime dateOfBirth, IUserLogic userLogic)
        {
            var user = new User(name, dateOfBirth);

            userLogic.Add(user);
        }

        static void ShowUsers(IUserLogic userLogic)
        {
            foreach (var item in userLogic.GetAll())
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Date: {item.DateofBirth.ToShortDateString()} Age: {item.Age}");
            }
        }
    }
}

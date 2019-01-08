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
            var awardLogic = Dependency.AwardLogic;
            //NewUser("Егор Андроновыв", new DateTime(1996, 04, 05), userLogic);
            //NewUser("Вася Пупкин", new DateTime(1996, 01, 06), userLogic);
            //NewUser("Вася Лупкин", new DateTime(1996, 01, 04), userLogic);
            //NewUser("Петя", new DateTime(1996, 01, 05), userLogic);
            //NewUser("Юля", new DateTime(1996, 02, 03), userLogic);
            //NewUser("Коля", new DateTime(1991, 01, 05), userLogic);

            //NewAward("Gold", awardLogic);
            //NewAward("Serebro", awardLogic);
            //NewAward("Bronze", awardLogic);
            NewAward("New", awardLogic);
            ShowAwards(awardLogic);
            awardLogic.Save();
            ShowUsers(userLogic);
            userLogic.Save();
        }

        static void NewUser(string name, DateTime dateOfBirth, IUserLogic userLogic)
        {
            var user = new User(name, dateOfBirth);

            userLogic.Add(user);
        }

        static void NewAward(string title, IAwardLogic awardLogic)
        {
            Award award = new Award { Title = title};

            awardLogic.AddAwards(award);
        }

        static void ShowAwards(IAwardLogic awardLogic)
        {
            foreach (var item in awardLogic.GetAllAward())
            {
                Console.WriteLine($"Id: {item.Id} Title: {item.Title}");
            }
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

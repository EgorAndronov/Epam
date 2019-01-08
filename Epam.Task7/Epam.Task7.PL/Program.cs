using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL.Interface;
using Epam.Task7.Common;
using Epam.Task7.Entities;

namespace Epam.Task7.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var userLogic = Dependency.UserLogic;
                var awardLogic = Dependency.AwardLogic;
                while (true)
                {
                    Console.WriteLine("Click \"1\" to add a user. Click \"2\" to delete the user. Click \"3\" to open the list of users. Click \"4\" to add a award to the list. Click \"5\" to add award for user. Press \"6\" for a list of awards.");

                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Enter Name");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter Date of Birthday");
                                Console.WriteLine("Year:");
                                if (int.TryParse(Console.ReadLine(), out int year))
                                {
                                    Console.WriteLine("Month:");
                                    if (int.TryParse(Console.ReadLine(), out int month))
                                    {
                                        Console.WriteLine("Day:");
                                        if (int.TryParse(Console.ReadLine(), out int day))
                                        {
                                            NewUser(name, new DateTime(year, month, day), userLogic);
                                        }
                                    }
                                }

                                break;
                            case 2:
                                Console.WriteLine("Enter id");
                                if (int.TryParse(Console.ReadLine(), out int id))
                                {
                                    userLogic.Delete(id);
                                }
                                else
                                {
                                    Console.WriteLine("Entered wrong id");
                                }

                                break;
                            case 3:
                                ShowUsers(userLogic);
                                break;
                            case 4:
                                Console.WriteLine("Enter title of award");
                                string title = Console.ReadLine();
                                NewAward(title, awardLogic);
                                break;
                            case 5:
                                Console.WriteLine("Enter id of user");
                                if (int.TryParse(Console.ReadLine(), out int idUser))
                                {
                                    Console.WriteLine("Enter id of award");
                                    if (int.TryParse(Console.ReadLine(), out int idAward))
                                    {
                                        Console.WriteLine("Enter id of award");
                                        var user = userLogic.GetById(idUser);
                                        var award = awardLogic.GetById(idAward);
                                        userLogic.AddAward(user, award);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong id");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Wrong id");
                                }

                                break;
                            case 6:
                                ShowAwards(awardLogic);
                                break;
                        }
                    }

                    Console.WriteLine("Click \"stop\" to exit the program or any button to continue.");
                    string stop = Console.ReadLine();
                    if (stop == "stop")
                    {
                        break;
                    }
                }

                awardLogic.Save();
                userLogic.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void NewUser(string name, DateTime dateOfBirth, IUserLogic userLogic)
        {
            var user = new User(name, dateOfBirth);
            userLogic.Add(user);
        }

        public static void NewAward(string title, IAwardLogic awardLogic)
        {
            Award award = new Award { Title = title };

            awardLogic.AddAwards(award);
        }

        public static void ShowAwards(IAwardLogic awardLogic)
        {
            foreach (var item in awardLogic.GetAllAward())
            {
                Console.WriteLine($"Id: {item.Id} Title: {item.Title}");
            }
        }

        public static void ShowUsers(IUserLogic userLogic)
        {
            foreach (var item in userLogic.GetAll())
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Date: {item.DateofBirth.ToShortDateString()} Age: {item.Age}");
                if (item.Awards != null)
                {
                    foreach (var aw in item.Awards)
                    {
                        Console.WriteLine($"Awards {aw.Title}");
                    }
                }
            }
        }
    }
}

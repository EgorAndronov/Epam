using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.BLL
{
    public class RegisteredUsersLogic : IRegisteredUsersLogic
    {

        private readonly IRegisteredUsersDao registeredDao;

        public RegisteredUsersLogic(IRegisteredUsersDao registeredDao)
        {
            this.registeredDao = registeredDao;
        }

        public void Add(string logIn, string password)
        {
            this.registeredDao.Add(logIn, password);
        }

        public bool Exist(string login, string password)
        {
            return this.registeredDao.Exist(login, password);
        }
    }
}

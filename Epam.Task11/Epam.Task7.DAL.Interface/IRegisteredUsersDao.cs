using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.DAL.Interface
{
    public interface IRegisteredUsersDao
    {
        void Add(string logIn, string password);

        bool Exist(string login, string password);
    }
}

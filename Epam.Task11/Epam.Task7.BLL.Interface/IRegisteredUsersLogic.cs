using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.BLL.Interface
{
    public interface IRegisteredUsersLogic
    {
        bool Exist(string login, string password);

        void Add(string logIn, string password);
    }
}

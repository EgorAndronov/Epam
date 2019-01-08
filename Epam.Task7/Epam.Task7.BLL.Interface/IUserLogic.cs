using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Entities;

namespace Epam.Task7.BLL.Interface
{
    public interface IUserLogic
    { 
        void Add(User user);

        void Delete(int id);

        IEnumerable<User> GetAll();

        void Save();

        User GetById(int id);

        void AddAward(User user, Award award);
    }
}

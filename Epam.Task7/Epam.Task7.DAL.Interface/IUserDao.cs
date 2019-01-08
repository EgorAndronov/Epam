using Epam.Task7.BLL.Interface;
using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.DAL.Interface
{
    public interface IUserDao
    {
        void Save(ICacheLogic<int, User> cacheLogic);

        IEnumerable<String> Get();
    }
}

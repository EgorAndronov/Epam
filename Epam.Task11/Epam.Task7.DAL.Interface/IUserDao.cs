using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL.Interface;
using Epam.Task7.Entities;
using System.Drawing;

namespace Epam.Task7.DAL.Interface
{
    public interface IUserDao
    {
        void Save(ICacheLogic<int, User> cacheLogic);

        IEnumerable<User> Get();

        void Add(User user);

        void Delete(int id);

        void AddAwardForUser(int idUser, int idAward);

        IEnumerable<IEnumerable<int>> GetUserAward();

        User GetById(int id);

        void Update(User user);

        void PutImageOfUser(int id, string pathFile);

        string GetImageBase64FromDb(int id);
    }
}

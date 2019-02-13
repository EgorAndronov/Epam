using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using Newtonsoft.Json;

namespace Epam.Task7.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDao userDao;
        private readonly ICacheLogic<int, User> cacheLogic;

        public UserLogic(IUserDao userDao, ICacheLogic<int, User> cacheLogic)
        {
            this.userDao = userDao;
            this.cacheLogic = cacheLogic;
            this.FillCache();
        }

        public void Add(User user)
        {
            int lastId;
            if (this.cacheLogic.GetKeys().Any())
            {
                lastId = this.cacheLogic.GetKeys().Max();
            }
            else
            {
                lastId = 0;
            }

            user.Id = ++lastId;

            this.cacheLogic.Add(user.Id, user);
        }

        public void Delete(int id)
        {
            this.cacheLogic.Delete(id);
        }

        public void Change(int id, User user)
        {
            this.cacheLogic.Delete(id);
            user.Id = id;
            this.cacheLogic.Add(id, user);
        }

        public IEnumerable<User> GetAll()
        {
            return this.cacheLogic.GetAll();
        }

        public User GetById(int id)
        {
            return this.cacheLogic.GetById(id);
        }

        public void Save()
        {
            this.userDao.Save(this.cacheLogic);
        }

        public void AddAward(User user, Award award)
        {
            user.Awards.Add(award);
        }

        private void FillCache()
        {
            foreach (var item in this.userDao.Get())
            {
                User user = JsonConvert.DeserializeObject<User>(item);
                this.cacheLogic.Add(user.Id, user);
            }
        }
    }
}

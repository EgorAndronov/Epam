using System;
using System.Collections.Generic;
using System.Drawing;
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
        }

        public void Add(User user)
        {
            this.cacheLogic.DeleteAll();
            this.userDao.Add(user);
        }

        public void Delete(int id)
        {
            this.cacheLogic.DeleteAll();
            this.userDao.Delete(id);
        }

        public void Update(User user)
        {
            this.cacheLogic.DeleteAll();

            this.userDao.Update(user);
        }

        public IEnumerable<User> GetAll()
        {
            var result = this.cacheLogic.GetAll();
            if(result.Count() == 0) { 
                foreach (var item in this.userDao.Get())
                {
                    this.cacheLogic.Add(item.Id, item);
                }
                return this.cacheLogic.GetAll(); 
            }
            else
            {
                return result;
            }

        }

        public User GetById(int id)
        {
            return this.userDao.GetById(id);
        }

        public void AddAwardForUser(int idUser, int idAward)
        {
            this.userDao.AddAwardForUser(idUser, idAward);
        }

        public void Save()
        {
            this.userDao.Save(this.cacheLogic);
        }

        public IEnumerable<IEnumerable<int>> GetUserAward()
        {
            return userDao.GetUserAward();
        }

        public void PutImageOfUser(int id, string pathFile)
        {
            this.userDao.PutImageOfUser(id, pathFile);
        }

        public string GetImageBase64FromDb(int id)
        {
            return this.userDao.GetImageBase64FromDb(id);
        }
    }
}

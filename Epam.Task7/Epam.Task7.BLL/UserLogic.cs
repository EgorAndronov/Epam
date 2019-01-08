﻿using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Epam.Task7.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDao userDao;
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
            if (cacheLogic.GetKeys().Any())
            {
                lastId = cacheLogic.GetKeys().Max();
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

        public IEnumerable<User> GetAll()
        {
            return cacheLogic.GetAll();
        }


        public void Save()
        {
            userDao.Save(cacheLogic);
        }

        private void FillCache()
        {
            foreach (var item in userDao.Get())
            {
                User user = JsonConvert.DeserializeObject<User>(item);
                cacheLogic.Add(user.Id, user);
            }
        }
    }
}

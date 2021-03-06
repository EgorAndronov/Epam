﻿using System;
using System.Collections.Generic;
using System.Drawing;
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

        void Update(User user);

        IEnumerable<User> GetAll();

        void Save();

        User GetById(int id);

        void AddAwardForUser(int idUser, int idAward);

        IEnumerable<IEnumerable<int>> GetUserAward();

        void PutImageOfUser(int id, string pathFile);

        string GetImageBase64FromDb(int id);

    }
}

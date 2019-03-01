using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using Newtonsoft.Json;

namespace Epam.Task7.DAL
{
    public class UserDao : IUserDao
    {
        private FileInfo file = new FileInfo(Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "Data_of_users.txt"));

        private FileInfo fileUA = new FileInfo(Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "UsersAwards.txt"));

        public void Add(User user)
        {
            if (File.ReadAllLines(this.file.FullName).Count() != 0)
            {
                var last = File.ReadAllLines(this.file.FullName).Last();
                User userLast = JsonConvert.DeserializeObject<User>(last);
                user.Id = userLast.Id + 1;
            }
            else
            {
                user.Id = 1;
            }
            using (StreamWriter sw = this.file.AppendText())
            {

                string serialize = JsonConvert.SerializeObject(user);
                sw.WriteLine(serialize);

            }
        }

        public void AddAwardForUser(int idUser, int idAward)
        {
            
            string result = idUser + "|" + idAward;
            using (StreamWriter sw = this.fileUA.AppendText())
            {

                sw.WriteLine(result);

            }
        }

        public void Delete(int id)
        {
            string line = string.Empty;
            var result = new List<string>();
            StreamReader sr = new StreamReader(this.file.FullName);
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    User user = JsonConvert.DeserializeObject<User>(line);
                    if (user.Id != id)
                    {
                        result.Add(line);
                    }

                }
            }

            sr.Close();

            File.WriteAllText(this.file.FullName, string.Empty);
            using (StreamWriter sw = this.file.AppendText())
            {
                foreach (var item in result)
                {
                    string serialize = JsonConvert.SerializeObject(item);
                    sw.WriteLine(serialize);
                }
            }


        }


        public IEnumerable<User> Get()
        {
            string line = string.Empty;
            List<User> result = new List<User>();
            StreamReader sr = new StreamReader(this.file.FullName);
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    User user = JsonConvert.DeserializeObject<User>(line);
                    result.Add(user);
                }
            }

            sr.Close();




            return result;
        }

        public IEnumerable<IEnumerable<int>> GetUserAward()
        {
            var result = new List<List<int>>();
            string line = string.Empty;
            StreamReader sr = new StreamReader(this.fileUA.FullName);
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    var array = line.Split(new char[] { '|' });
                    result.Add(new List<int> { int.Parse(array[0]), int.Parse(array[1]) });
                }
            }

            sr.Close();

            return result;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }



        public void PutImageOfUser(string pathFile)
        {
            throw new NotImplementedException();
        }

        public void Save(ICacheLogic<int, User> cacheLogic)
        {
            File.WriteAllText(this.file.FullName, string.Empty);
            using (StreamWriter sw = this.file.AppendText())
            {
                foreach (var item in cacheLogic.GetAll())
                {
                    string serialize = JsonConvert.SerializeObject(item);
                    sw.WriteLine(serialize);
                }
            }
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void PutImageOfUser(int id, string pathFile)
        {
            throw new NotImplementedException();
        }

        public Image GetImageBase64FromDb(int id)
        {
            throw new NotImplementedException();
        }
    }
}

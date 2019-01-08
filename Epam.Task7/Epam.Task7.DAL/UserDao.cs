using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.DAL
{
    public class UserDao : IUserDao
    {

        private FileInfo file = new FileInfo(Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "Data_of_users.txt"));

        public IEnumerable<String> Get()
        {
            string line = string.Empty;
            List<string> result = new List<string>();
            StreamReader sr = new StreamReader(file.FullName);
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    result.Add(line);
                }
            }
            sr.Close();
            return result;
        }

        public void Save(ICacheLogic<int, User> cacheLogic)
        {
            File.WriteAllText(file.FullName, string.Empty);
            using (StreamWriter sw = file.AppendText())
            {
                foreach (var item in cacheLogic.GetAll())
                {
                    string serialize = JsonConvert.SerializeObject(item);
                    sw.WriteLine(serialize);
                }
            }
        }

    }
}

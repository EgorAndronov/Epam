using System;
using System.Collections.Generic;
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
        private FileInfo file = new FileInfo(Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName, "Data", "Data_of_users.txt"));

        public IEnumerable<string> Get()
        {
            string line = string.Empty;
            List<string> result = new List<string>();
            StreamReader sr = new StreamReader(this.file.FullName);
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    result.Add(line);
                }
            }

            sr.Close();
            Console.WriteLine(this.file.FullName);
            return result;
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
    }
}

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
    public class AwardDao : IAwardDao
    {
        private FileInfo file = new FileInfo(Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName, "Data", "Awards.txt"));

        public IEnumerable<Award> Get()
        {
            string line = string.Empty;
            List<Award> result = new List<Award>();
            StreamReader sr = new StreamReader(this.file.FullName);
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    Award award = JsonConvert.DeserializeObject<Award>(line);
                    result.Add(award);
                }
            }

            sr.Close();
            return result;
        }

        public void Save(ICacheLogic<int, Award> cacheLogic)
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

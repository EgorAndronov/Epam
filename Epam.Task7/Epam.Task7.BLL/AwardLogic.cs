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
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDao awardDao;
        private readonly ICacheLogic<int, Award> cacheLogicAwards;

        public AwardLogic(IAwardDao awardDao, ICacheLogic<int, Award> cacheLogic)
        {
            this.awardDao = awardDao;
            this.cacheLogicAwards = cacheLogic;
            this.FillCache();
        }

        public IEnumerable<Award> GetAllAward()
        {
            return this.cacheLogicAwards.GetAll();
        }

        public void AddAwards(Award award)
        {
            int lastId;
            if (this.cacheLogicAwards.GetKeys().Any())
            {
                lastId = this.cacheLogicAwards.GetKeys().Max();
            }
            else
            {
                lastId = 0;
            }

            award.Id = ++lastId;

            this.cacheLogicAwards.Add(award.Id, award);
        }

        public Award GetById(int id)
        {
            return this.cacheLogicAwards.GetById(id);
        }

        public void Save()
        {
            this.awardDao.Save(this.cacheLogicAwards);
        }

        private void FillCache()
        {
            foreach (var item in this.awardDao.Get())
            {
                Award award = JsonConvert.DeserializeObject<Award>(item);
                this.cacheLogicAwards.Add(award.Id, award);
            }
        }
    }
}

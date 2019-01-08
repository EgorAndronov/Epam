using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.BLL
{
    public class AwardLogic : IAwardLogic
    {
        private IAwardDao awardDao;
        private readonly ICacheLogic<int, Award> cacheLogicAwards;


        public AwardLogic(IAwardDao awardDao, ICacheLogic<int, Award> cacheLogic)
        {
            this.awardDao = awardDao;
            this.cacheLogicAwards = cacheLogic;
            this.FillCache();
        }


        public IEnumerable<Award> GetAllAward()
        {
            return cacheLogicAwards.GetAll();
        }

        public void AddAwards(Award award)
        {
            int lastId;
            if (cacheLogicAwards.GetKeys().Any())
            {
                lastId = cacheLogicAwards.GetKeys().Max();
            }
            else
            {
                lastId = 0;
            }

            award.Id = ++lastId;

            this.cacheLogicAwards.Add(award.Id, award);
        }

        public void Save()
        {
            awardDao.Save(cacheLogicAwards);
        }

        private void FillCache()
        {
            foreach (var item in awardDao.Get())
            {
                Award award = JsonConvert.DeserializeObject<Award>(item);
                cacheLogicAwards.Add(award.Id, award);
            }
        }
    }
}

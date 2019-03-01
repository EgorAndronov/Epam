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
            var result = this.cacheLogicAwards.GetAll();
            if (result.Count() == 0)
            {
                foreach (var item in this.awardDao.Get())
                {
                    this.cacheLogicAwards.Add(item.Id, item);
                }
                return this.cacheLogicAwards.GetAll();
            }
            else
            {
                return result;
            }
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
            this.cacheLogicAwards.DeleteAll();
            this.awardDao.Add(award);
        }

        public void Delete(int id)
        {
            this.cacheLogicAwards.DeleteAll();
            this.awardDao.Delete(id);
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
               
                this.cacheLogicAwards.Add(item.Id, item);
            }
        }
    }
}

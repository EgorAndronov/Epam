using Epam.Task7.BLL;
using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Common
{
    public static class Dependency
    {
        private static ICacheLogic<int, User> cacheLogic;

        public static ICacheLogic<int, User> CacheLogic
        {
            get
            {
                return cacheLogic ?? (cacheLogic = new CacheLogic<int, User>()) ;
            }
        }

        private static ICacheLogic<int, Award> cacheLogicAwards;

        public static ICacheLogic<int, Award> CacheLogicAwards
        {
            get
            {
                return cacheLogicAwards ?? (cacheLogicAwards = new CacheLogic<int, Award>());
            }
        }

        private static IUserLogic userLogic;

        public static IUserLogic UserLogic
        {
            get
            {
                return userLogic ?? (userLogic = new UserLogic(UserDao, CacheLogic));
            }
        }

        private static IAwardLogic awardLogic;

        public static IAwardLogic AwardLogic
        {
            get
            {
                return awardLogic ?? (awardLogic = new AwardLogic(AwardDao, CacheLogicAwards));
            }
        }

        private static IAwardDao awardDao;

        public static IAwardDao AwardDao
        {
            get
            {
                return awardDao ?? (awardDao = new AwardDao());
            }
        }

        private static IUserDao userDao;

        public static IUserDao UserDao
        {
            get
            {
                return userDao ?? (userDao = new UserDao());
            }
        }

    }
}

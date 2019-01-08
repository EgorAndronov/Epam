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

        private static ICacheLogic<int, Award> cacheLogicAwards;

        private static IUserLogic userLogic;

        private static IAwardLogic awardLogic;

        private static IAwardDao awardDao;

        private static IUserDao userDao;

        public static ICacheLogic<int, User> CacheLogic
        {
            get
            {
                return cacheLogic ?? (cacheLogic = new CacheLogic<int, User>());
            }
        }

        public static ICacheLogic<int, Award> CacheLogicAwards
        {
            get
            {
                return cacheLogicAwards ?? (cacheLogicAwards = new CacheLogic<int, Award>());
            }
        }

        public static IUserLogic UserLogic
        {
            get
            {
                return userLogic ?? (userLogic = new UserLogic(UserDao, CacheLogic));
            }
        }

        public static IAwardLogic AwardLogic
        {
            get
            {
                return awardLogic ?? (awardLogic = new AwardLogic(AwardDao, CacheLogicAwards));
            }
        }

        public static IAwardDao AwardDao
        {
            get
            {
                return awardDao ?? (awardDao = new AwardDao());
            }
        }

        public static IUserDao UserDao
        {
            get
            {
                return userDao ?? (userDao = new UserDao());
            }
        }

    }
}

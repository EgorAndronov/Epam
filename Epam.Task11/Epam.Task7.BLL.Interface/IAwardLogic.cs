using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Entities;

namespace Epam.Task7.BLL.Interface
{
    public interface IAwardLogic
    {
        IEnumerable<Award> GetAllAward();

        void AddAwards(Award award);

        void Save();

        Award GetById(int id);

        void Delete(int id);
    }
}

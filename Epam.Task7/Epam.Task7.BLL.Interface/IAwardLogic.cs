using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.BLL.Interface
{
    public interface IAwardLogic
    {
        IEnumerable<Award> GetAllAward();

        void AddAwards(Award award);

        void Save();
    }
}

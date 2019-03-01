using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.BLL.Interface
{
    public interface ICacheLogic<K, T>
    {
        void Add(K key, T value);

        T GetById(K key);

        bool Delete(K key);

        IEnumerable<K> GetKeys();

        IEnumerable<T> GetAll();

        void DeleteAll();
    }
}

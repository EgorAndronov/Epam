using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL.Interface;

namespace Epam.Task7.BLL
{
    public class CacheLogic<K, T> : ICacheLogic<K, T>
    {
        private static Dictionary<K, T> cache = new Dictionary<K, T>();

        public void Add(K key, T value)
        {
            if (cache.ContainsKey(key))
            {
                throw new Exception("This key already exists");
            }
            else
            {
                cache.Add(key, value);
            }
        }

        public T GetById(K key)
        {
            if (cache.ContainsKey(key))
            {
                return cache[key];
            }

            return default(T);
        }

        public bool Delete(K key)
        {
            return cache.Remove(key);
        }

        public IEnumerable<K> GetKeys()
        {
            return cache.Keys;
        }

        public IEnumerable<T> GetAll()
        {
            return cache.Values;
        }
    }
}

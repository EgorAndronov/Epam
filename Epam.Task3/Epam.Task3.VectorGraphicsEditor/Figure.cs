using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public abstract class Figure
    {
        public abstract string Name { get; set; }

        public abstract string Show();

        protected void CheckValuePositive<T>(T val)
            where T : IComparable<T>
        {
            if (val.CompareTo(default(T)) <= 0)
            {
                throw new Exception($"Value <= 0");
            }
        }
    }
}

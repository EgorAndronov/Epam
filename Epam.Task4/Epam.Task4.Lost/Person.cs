using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.Lost
{
    public class Person
    {
        private string name = string.Empty;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.CheckString(value);
                this.name = value;
            }
        }

        public void CheckString(string val)
        {
            if (val == string.Empty)
            {
                throw new Exception("Empty value");
            }
        }

        public string Show()
        {
            return string.Format($"Name = {this.Name}");
        }
    }
}

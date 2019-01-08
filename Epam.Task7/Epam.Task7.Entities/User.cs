using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Entities
{
    public class User
    {
        public List<Award> Awards = new List<Award>();

        public User()
        {
        }

        public User(string name, DateTime date)
        {
            this.Name = name;
            this.DateofBirth = date;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateofBirth { get; set; }

        public int Age
        {
            get
            {
                int result = DateTime.Now.Year - this.DateofBirth.Year;
                if (DateTime.Now.Month < this.DateofBirth.Month || (DateTime.Now.Month == this.DateofBirth.Month && DateTime.Now.Day < this.DateofBirth.Day))
                {
                    result--;
                }

                return result;
            }
        }

        //public List<Award> Awards
        //{
        //    get
        //    {
        //        return this.award;
        //    }
        //    set
        //    {
        //        this.award = value;
        //    }
        //}
    }
}

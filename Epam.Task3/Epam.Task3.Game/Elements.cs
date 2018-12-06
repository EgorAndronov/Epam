using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Elements : IDisplay
    {
        public Elements(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual void Display()
        {
        }
    }
}

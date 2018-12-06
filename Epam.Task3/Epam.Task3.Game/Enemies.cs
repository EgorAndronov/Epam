using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Enemies : Elements, IMoves
    {
        public Enemies(string name) 
            : base(name)
        {
        }

        public void Move()
        {
        }

        public override void Display()
        {
        }
    }
}

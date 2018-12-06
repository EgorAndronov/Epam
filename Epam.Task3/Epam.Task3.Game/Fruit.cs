using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Fruit : Elements
    {
        public Fruit(string name) 
            : base(name)
        {
        }

        public void ChangeCharacteristic(Gamer gamer)
        {
            // Increase any characteristic
        }

        public override void Display()
        {
        }
    }
}

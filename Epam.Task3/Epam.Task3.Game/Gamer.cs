using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Gamer : IDisplay, IMoves
    {
        private int characteristic1;
        private int characteristic2;
        private int characteristic3;
        private int characteristic4;

        public Gamer(int ch1, int ch2, int ch3, int ch4)
        {
            this.characteristic1 = ch1;
            this.characteristic2 = ch2;
            this.characteristic3 = ch3;
            this.characteristic4 = ch4;
        }

        public int Characteristic1
        {
            get
            {
                return this.characteristic1;
            }

            set
            {
                this.characteristic1 = value;
            }
        }

        public int Characteristic2
        {
            get
            {
                return this.characteristic2;
            }

            set
            {
                this.characteristic2 = value;
            }
        }

        public int Characteristic3
        {
            get
            {
                return this.characteristic3;
            }

            set
            {
                this.characteristic3 = value;
            }
        }

        public int Characteristic4
        {
            get
            {
                return this.characteristic4;
            }

            set
            {
                this.characteristic4 = value;
            }
        }

        public void Display()
        {
        }

        public void Move()
        {
        }
    }
}

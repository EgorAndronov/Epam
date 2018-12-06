using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public class Field : IDisplay
    {
        private int width;
        private int height;

        public Field(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.CheckValuePositive(value);
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.CheckValuePositive(value);
                this.height = value;
            }
        }

        public void Display()
        {
        }

        protected void CheckValuePositive(int val)
        {
            if (val <= 0)
            {
                throw new Exception($"Value <= 0");
            }
        }
    }
}

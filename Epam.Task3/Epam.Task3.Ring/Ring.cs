using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Ring
{
    public class Ring
    {
        private int[] coor = new int[2];
        private int innerRadius;
        private int outerRadius;
        private float square;

        public Ring()
        {
        }
        public Ring(int innerR, int outerR)
        {
            this.InnerRadius = innerR;
            this.OuterRadius = outerR;
        }
        public Ring(int innerR, int outerR, int[] coor)
        {
            this.InnerRadius = innerR;
            this.OuterRadius = outerR;
            this.Coor = coor;
        }

        public int InnerRadius
        {
            get
            {
                return this.innerRadius;
            }
            set
            {
                this.innerRadius = value;
            }
        }

        public int OuterRadius
        {
            get
            {
                return this.outerRadius;
            }
            set
            {
                this.outerRadius = value;
            }
        }

        public int[] Coor
        {
            get
            {
                return this.coor;
            }
            set
            {
                this.coor = value;
            }
        }

        public float Square
        {
            get
            {
                return this.square;
            }
            set
            {
                this.square = (float)Math.PI * (float)(Math.Pow(this.outerRadius, 2) - Math.Pow(this.innerRadius, 2));
            }
        } 

    }
}

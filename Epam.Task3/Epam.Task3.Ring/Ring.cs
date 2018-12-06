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
        private double innerRadius;
        private double outerRadius;
        
        public Ring()
        {
        }

        public Ring(double innerR, double outerR)
        {
            this.InnerRadius = innerR;
            this.OuterRadius = outerR;
        }

        public Ring(double innerR, double outerR, int[] coor)
        {
            this.InnerRadius = innerR;
            this.OuterRadius = outerR;
            this.Coor = coor;
        }

        public double InnerRadius
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

        public double OuterRadius
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

        public double InnerLength
        {
            get
            {
                return 2 * Math.PI * this.InnerRadius;
            }
        }

        public double OuterLength
        {
            get
            {
                return 2 * Math.PI * this.OuterRadius;
            }
        }

        public double SumLength
        {
            get
            {
                return this.InnerLength + this.OuterLength;
            }
        } 

        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(this.outerRadius, 2) - Math.Pow(this.innerRadius, 2));
            }
        } 
    }
}

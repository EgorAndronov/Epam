using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Round
{
    public class Round
    {
        private int[] coordinatesCenter = new int[2];
        private double radius;

        public Round()
            : this(new int[] { 0, 0 }, 1)
        {
        }

        public Round(int[] coor)
            : this(coor, 1)
        {
        }

        public Round(int[] coor, int radius)
        {
            this.CoordinatesCenter = coor;
            this.Radius = radius;
        }

        public int[] CoordinatesCenter
        {
            get
            {
                return this.coordinatesCenter;
            }

            set
            {
                this.PositiveValueCheck(value[0]);
                this.PositiveValueCheck(value[1]);
                this.coordinatesCenter = value;
            }
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                this.PositiveValueCheck(value);
                this.NotZeroValueCheck(value);
                this.radius = value;
            }
        }

        public double LengthRound
        {
            get
            {
                return 2 * Math.PI * this.Radius;
            }
        }

        public double AreaRound
        {
            get
            {
                return Math.PI * Math.Pow(this.Radius, 2);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Coordinates of center: {CoordinatesCenter[0]}, {CoordinatesCenter[1]}, radius: {Radius}, length: {LengthRound}, area: {AreaRound}");
        }

        private void PositiveValueCheck(int x)
        {
            if (x < 0)
            {
                throw new Exception("Value < 0!");
            }
        }

        private void PositiveValueCheck(double x)
        {
            if (x < 0)
            {
                throw new Exception("Value < 0!");
            }
        }

        private void NotZeroValueCheck(int x)
        {
            if (x == 0)
            {
                throw new Exception("Value = 0!");
            }
        }

        private void NotZeroValueCheck(double x)
        {
            if (x == 0)
            {
                throw new Exception("Value = 0!");
            }
        }
    }
}

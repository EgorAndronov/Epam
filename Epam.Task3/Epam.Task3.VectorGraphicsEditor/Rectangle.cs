using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Rectangle : Figure
    {
        private int side1;
        private int side2;

        public Rectangle(string name, int side1, int side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Name = name;
        }

        public override string Name { get; set; }

        public int Side1
        {
            get
            {
                return this.side1;
            }

            set
            {
                this.CheckValuePositive(value);
                this.side1 = value;
            }
        }

        public int Side2
        {
            get
            {
                return this.side2;
            }

            set
            {
                this.CheckValuePositive(value);
                this.side2 = value;
            }
        }

        public int Perimeter
        {
            get
            {
                return 2 * (this.Side1 + this.Side2);
            }
        }

        public int Area
        {
            get
            {
                return this.Side1 * this.Side2;
            }
        }

        public override string Show()
        {
            return $"Rectangle: name: {this.Name}, first side = {this.Side1}, second side = {this.Side2},  perimeter = {this.Perimeter}, area = {this.Area}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Circle : Figure
    {
        private double radius;
        
        public Circle(string name, double radius)
        {
            this.Radius = radius;
            this.Name = name;
        }

        public override string Name { get; set; }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                this.CheckValuePositive(value);
                this.radius = value;
            }
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * this.Radius;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(this.Radius, 2);
            }
        }

        public override string Show()
        {
            return $"Circle: name: {this.Name}, radius = {this.Radius}, length = {this.Length}, area = {this.Area}";
        }
    }
}

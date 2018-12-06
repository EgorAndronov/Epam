using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Round : Figure
    {
        private double radius;

        public Round(string name, double radius)
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

        public override string Show()
        {
            return $"Round: name: {this.Name}, radius = {this.Radius}, length = {this.Length}";
        }
    }
}

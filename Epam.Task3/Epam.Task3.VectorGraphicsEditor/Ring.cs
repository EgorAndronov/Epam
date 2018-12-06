using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Ring : Figure 
    {
        private int innerRadius;
        private int outerRadius;
        
        public Ring(string name, int innerR, int outerR)
        {
            this.InnerRadius = innerR;
            this.OuterRadius = outerR;
            this.Name = name;
        }

        public override string Name { get; set; }

        public int InnerRadius
        {
            get
            {
                return this.innerRadius;
            }

            set
            {
                this.CheckValuePositive(value);
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
                this.CheckValuePositive(value);
                this.CheckRadius(this.InnerRadius, value);
                this.outerRadius = value;
            }
        }
        
        public double Area
        {
            get
            {
                return (float)Math.PI * (float)(Math.Pow(this.outerRadius, 2) - Math.Pow(this.innerRadius, 2));
            }            
        }

        public void CheckRadius(int rad1, int rad2)
        {
            if (rad1 >= rad2)
            {
                throw new Exception("Ring does not exist");
            }
        }

        public override string Show()
        {
            return $"Ring: name: {this.Name}, inner radius = {this.InnerRadius}, outer radius = {this.OuterRadius}, area = {this.Area}";
        }
    }
}

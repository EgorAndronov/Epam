using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    public class Line : Figure
    {
        private int length;
        
        public Line(string name, int len)
        {
            this.Length = len;
            this.Name = name;
        }

        public override string Name { get; set; }

        public int Length
        {
            get
            {
                return this.length;
            }

            set
            {
                this.CheckValuePositive(value);
                this.length = value;
            }
        }

        public override string Show()
        {
            return $"Line: name: {this.Name}, length = {this.Length}";
        }        
    }
}

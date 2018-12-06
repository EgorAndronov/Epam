using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Triangle
{
    public class Triangle
    {
        private int a;
        private int b;
        private int c;

        public Triangle() : this(1, 1, 1)
        {
        }

        public Triangle(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            try
            {
                this.ExistTriangle(this.A, this.B, this.C);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public int A
        {
            get
            {
                return this.a;
            }

            set
            {
                try
                {
                    this.ValueCheck(value);
                    this.a = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public int B
        {
            get
            {
                return this.b;
            }

            set
            {
                try
                {
                    this.ValueCheck(value);
                    this.b = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public int C
        {
            get
            {
                return this.c;
            }

            set
            {
                try
                {
                    this.ValueCheck(value);
                    this.c = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public int Perimeter
        {
            get
            {
                return this.a + this.b + this.c;
            }
        }

        public double Area
        {
            get
            {
                double halfPerimeter = (double)this.Perimeter / 2;
                return Math.Pow(halfPerimeter * (halfPerimeter - this.A) * (halfPerimeter - this.B) * (halfPerimeter - this.C), 0.5);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Sides: a = {A}, b = {B}, c = {C}, perimeter = {Perimeter}, area = {Area}");
        }

        private void ExistTriangle(int a, int b, int c)
        {
            if (!(((a + b) > c) & ((a + c) > b) & ((b + c) > a)))
            {
                throw new Exception("The triangle does not exist");
            }
        }

        private void ValueCheck(int x)
        {
            if (x < 0)
            {
                throw new Exception("Value < 0!");
            }
            else if (x == 0)
            {
                throw new Exception("Value = 0!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0204_Clone
{
    public class Shape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string Color { get; set; }

        public Shape()
        {

        }

        public Shape(Shape source)
        {
            this.X = source.X;
            this.Y = source.Y;
            this.Color = source.Color;
        }

        public virtual Shape Clone()
        {
            return new Shape(this);
        }
    }

    public class Rectangle: Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(Rectangle source): base(source)
        {
            this.Width = source.Width;
            this.Height = source.Height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }

    public class Circle: Shape
    {
        public int Radius { get; set; }

        public Circle()
        {

        }

        public Circle(Circle source):base(source)
        {
            this.Radius = source.Radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}

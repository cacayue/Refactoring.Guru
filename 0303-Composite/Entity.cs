using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0303_Composite
{
    public interface Graphic
    {
        void Move(int x, int y);

         void Draw();
    }

    public class CompoundGraphic: Graphic
    {
        public List<Graphic> Graphics { get; set; }

        public CompoundGraphic()
        {
            Graphics = new List<Graphic>();
        }

        public void Add(Graphic graphic)
        {
            Graphics.Add(graphic);
        }

        public void Remove(Graphic graphic)
        {
            Graphics.Remove(graphic);
        }

        public void Move(int x, int y)
        {
            foreach (var graphic in Graphics)
            {
                graphic.Move(x, y);
            }
        }

        public void Draw()
        {
            foreach (var graphic in Graphics)
            {
                graphic.Draw();
            }
        }
    }

    public class Dot: Graphic
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Dot {X}--{Y}");
        }
    }

    public class Circle: Dot
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle {X}--{Y}--{Radius}");
        }
    }

    public class ImageEditor
    {
        public List<Graphic> All { get; set; } = new List<Graphic>();

        public void Load()
        {
            All.Add(new Dot(1, 2));
            All.Add(new Circle(1, 2, 3));
        }
        
        public void GroupSelected(List<Graphic> components)
        {
            var group = new CompoundGraphic();
            foreach (var graphic in components)
            {
                group.Add(graphic);
                All.Remove(graphic);
            }
            All.Add(group);
            foreach (var item in All)
            {
                item.Draw();
            }
        }
    }
}

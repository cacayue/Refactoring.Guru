using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0204_Clone
{
    public interface Prototype
    {

        public string GetColor();

        public Prototype Clone();
    }

    public class Button: Prototype
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string Color { get; set; }

        public Button(int x, int y, string color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public Button(Prototype prototype)
        {

        }

        public string GetColor()
        {
            return Color;
        }

        public Prototype Clone()
        {

            return new Button(this);
        }


    }

    public class PrototypeRegistry
    {
        public Dictionary<string, Prototype> Items { get; set; } = new Dictionary<string, Prototype>();

        public void AddItem(string id, Prototype p)
        {
            Items.Add(id, p);
        }

        public Prototype? GetById(string id)
        {
            Items.TryGetValue(id, out Prototype? p);
            return p;
        }

        public Prototype GetByColor(string color)
        {
            var p = Items.FirstOrDefault(x => x.Value.GetColor() == color);

            return p.Value;
        }
    }
}

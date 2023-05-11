using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0301_Adapter
{
    public class RoundPeg
    {
        public int Radius { get; set; }

        public RoundPeg()
        {

        }

        public RoundPeg(int radius)
        {
            Radius = radius;    
        }

        public virtual int GetRadius()
        {
            return Radius;
        }
    }

    public class RoundHole
    {
        public int Radius { get; set; }

        public RoundHole(int radius)
        {
            Radius = radius;
        }

        public int GetRadius()
        {
            return Radius; 
        }

        public bool Fits(RoundPeg peg)
        {
            return peg.GetRadius() <= Radius;
        }
    }

    public class SquarePeg
    {
        public int Width { get; set; }

        public SquarePeg(int width)
        {
            Width = width;
        }

        public int GetWidth()
        {
            return Width;
        }
    }

    public class SquarePegAdapter: RoundPeg
    {
        public SquarePeg SquarePeg { get; set; }

        public SquarePegAdapter(SquarePeg peg)
        {
            SquarePeg = peg;
        }

        public override int GetRadius()
        {
            var r = SquarePeg.GetWidth() * Math.Sqrt(2) / 2;
            return (int)(r);
        }
    }
}

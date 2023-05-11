namespace _0301_Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var roundPeg = new RoundPeg(5);
            var roundHole = new RoundHole(5);


            var ssquare = new SquarePeg(5);
            var bsquare = new SquarePeg(10);


            var rg = roundHole.Fits(roundPeg);
            Console.WriteLine($"{rg}");

            var sadapter = new SquarePegAdapter(ssquare);
            var badapter = new SquarePegAdapter(bsquare);


            var fg1 = roundHole.Fits(sadapter);
            var fg2 = roundHole.Fits(badapter);
            Console.WriteLine($"{fg1}");
            Console.WriteLine($"{fg2}");

        }
    }
}
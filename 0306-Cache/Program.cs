namespace _0306_Cache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var forest = new Forest();
            forest.PlantTree(1, 2, "test1", "red", "aaa");
            forest.PlantTree(1, 2, "test2", "red", "aaa");
            forest.PlantTree(1, 1, "test1", "red", "aaa");
            forest.PlantTree(1, 1, "test2", "red", "aaa");
            forest.Draw("start");
        }
    }
}
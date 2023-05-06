namespace _0204_Clone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new Application();

            var shapes = app.CopyArray();
        }

        public class Application
        {
            public List<Shape> Shapes { get; set; } = new List<Shape>();

            public Application()
            {
                var circle = new Circle();
                circle.X = 10;
                circle.Y = 10;
                circle.Radius = 20;
                Shapes.Add(circle);

                var anotherCircle = circle.Clone();
                Shapes.Add(anotherCircle);

                var rectangle = new Rectangle();
                rectangle.Width = 10;
                rectangle.Height = 20;
                Shapes.Add(rectangle);

            }

            public List<Shape> CopyArray()
            {
                return Shapes.Select(x => x.Clone()).ToList();

            }
        }
    }
}
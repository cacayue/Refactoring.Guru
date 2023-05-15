namespace _0303_Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editer = new ImageEditor();
            //editer.Load();
            editer.GroupSelected(new List<Graphic> {
                new Dot(2, 3),
                new Circle(5,3,4)
            }) ;

        }
    }
}
namespace _0304_Wapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var com = new ConcreteComponent();
            //var wapper = new ConcreteDecorators(com);

            //wapper.Execute();

            var file = new FileDataSource("001");

            var wapper = new EncryptionDecorator(file);

            wapper.WriteData("2121");

            Console.WriteLine(wapper.GetData());
        }
    }
}
namespace _0305_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var convert = new VideoConverter();

            var convertFile =  convert.ConvertVideo("001", "mp4");

            Console.WriteLine(convertFile);
        }
    }
}
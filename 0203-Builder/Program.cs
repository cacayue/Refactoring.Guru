namespace _0203_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dirctor = new Director();
            var carBuilder = new CarBuilder();
            var carManualBuilder = new CarManualBuilder();
            #region SUV

            dirctor.MakeSUV(carBuilder);
            dirctor.MakeSUV(carManualBuilder);
            var suv = carBuilder.GetResult();
            var suvManual = carManualBuilder.GetResult();

            Console.Write(suv.ToString());
            Console.WriteLine(suvManual.ToString());
            #endregion

            #region Sports

            dirctor.MakeSportsCar(carBuilder);
            dirctor.MakeSportsCar(carManualBuilder);
            var sports = carBuilder.GetResult();
            var sportsManual = carManualBuilder.GetResult();

            Console.Write(sports.ToString());
            Console.WriteLine(sportsManual.ToString());

            #endregion


        }
    }
}
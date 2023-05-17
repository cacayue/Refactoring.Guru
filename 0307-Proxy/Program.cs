namespace _0307_Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tvService = new ThirdPartyTVClass();
            var proxy = new CachedTVClass(tvService);

            var list = proxy.ListVideos();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
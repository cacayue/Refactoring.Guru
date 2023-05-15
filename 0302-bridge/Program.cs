namespace _0302_bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var radio = new Radio();
            var advanceRemote = new AdvanceRemote(radio);

            advanceRemote.TogglePower();

            advanceRemote.ChannelDown();

            advanceRemote.VolumeUp();

            advanceRemote.Mute();

            Console.WriteLine(advanceRemote.Device.ToString());
        }
    }
}
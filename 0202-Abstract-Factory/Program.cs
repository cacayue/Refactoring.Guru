namespace _0202_Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = Console.ReadLine();

            GUIFactory factory1 = new DefaultGUIFactory();
            // 需要写Switch切换新加入的工厂
            if (d.ToLower() == "windows")
            {
                factory1 = new WinGUIFactory();
            }
            else if (d.ToLower() == "mac")
            {
                factory1 = new MacGUIFactory();
            }

            new Application(factory1);

        }

        public class Application {

            public Application(GUIFactory factory)
            {
                factory.CreateButton();
                factory.CreateCheckBox();
            }
        }
    }
}
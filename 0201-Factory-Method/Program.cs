namespace _0201_Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = Console.ReadLine();



            var dialog = new Dialog();

            if (d.ToLower() == "windows")
            {
                dialog = new WindowsDialog();
            }
            else if(d.ToLower() == "web")
            {
                dialog = new WebDialog();
            }

            dialog.Render();

        }
    }
}
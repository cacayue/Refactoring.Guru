namespace _0402_Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor01 = new Editor("Text-----001");
            var editor02 = new Editor("Text-----002");
            var app = new Application();


            var copyCommand = new CopyCommand(app, editor01);
            var pasteCommand1 = new PasteCommand(app, editor01);
            var cutCommand = new CutCommand(app, editor02);
            var pasteCommand2 = new PasteCommand(app, editor02);
         
            

            app.ExecuteCommand(copyCommand);
            Console.WriteLine($"editor01 -- {editor01.GetSelection()}");
            Console.WriteLine($"editor02 -- {editor02.GetSelection()}");

            app.ExecuteCommand(pasteCommand2);
            Console.WriteLine($"editor01 -- {editor01.GetSelection()}");
            Console.WriteLine($"editor02 -- {editor02.GetSelection()}");

            app.Undo();
            Console.WriteLine($"editor01 -- {editor01.GetSelection()}");
            Console.WriteLine($"editor02 -- {editor02.GetSelection()}");

            app.ExecuteCommand(cutCommand);
            Console.WriteLine($"editor01 -- {editor01.GetSelection()}");
            Console.WriteLine($"editor02 -- {editor02.GetSelection()}");

            app.Undo();
            Console.WriteLine($"editor01 -- {editor01.GetSelection()}");
            Console.WriteLine($"editor02 -- {editor02.GetSelection()}");

            app.ExecuteCommand(pasteCommand1);
            Console.WriteLine($"editor01 -- {editor01.GetSelection()}");
            Console.WriteLine($"editor02 -- {editor02.GetSelection()}");
        }
    }
}
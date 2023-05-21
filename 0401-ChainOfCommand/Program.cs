namespace _0401_ChainOfCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dialog = new Dialog();
            dialog.WikiPageURL = "Http";
            var panel = new Panel();
            panel.ModalHelpText = "设置面板";
            var okbtn  = new Button();
            okbtn.TooltipText = "确认按钮";
            var  cancelbtn = new Button();
            cancelbtn.TooltipText = "取消按钮";

            panel.Add(okbtn);
            panel.Add(cancelbtn);
            dialog.Add(panel);
            okbtn.ShowHelp();
        }
    }
}
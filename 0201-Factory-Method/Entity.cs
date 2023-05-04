using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0201_Factory_Method
{
    public class Dialog
    {
        public virtual void Render()
        {
            var btn = CreateButton();
            btn.Render();
            btn.OnClick();
            Console.WriteLine("Dialog Render");
        }

        protected virtual Button CreateButton()
        {
            return new Button();
        }
    }

    public class WindowsDialog : Dialog
    {
        protected override Button CreateButton()
        {
            return new WindwosButton();
        }
    }
    public class WebDialog : Dialog
    {
        protected override Button CreateButton()
        {
            return new HtmlButton();
        }
    }

    public class Button
    {
        public virtual void Render()
        {
            Console.WriteLine("Button Render");
        }

        public virtual void OnClick()
        {
            Console.WriteLine("Button Click");
        }

    }

    public class WindwosButton:Button
    {
        public override void OnClick()
        {
            Console.WriteLine("WindwosButton Click");
        }

    }

    public class HtmlButton : Button
    {
        public override void OnClick()
        {
            Console.WriteLine("HtmlButton Click");
        }

    }
}

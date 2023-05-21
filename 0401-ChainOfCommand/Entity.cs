using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0401_ChainOfCommand
{
    public interface ComponentWithContextualHelp
    {
        void ShowHelp();
    }

    public class Component: ComponentWithContextualHelp
    {
        public Container Container { get; set; }

        public string TooltipText { get; set; }

        public virtual void ShowHelp()
        {
            if (!string.IsNullOrEmpty(TooltipText))
            {
                Console.WriteLine(TooltipText); 
            }
            else
            {
                Container.ShowHelp();
            }
        }
    }

    public class Container: Component
    {

        public List<Component> Children { get; set; } = new List<Component>();

        public virtual void Add(Component component)
        {
            Children.Add(component);
            Container = this;
        }
    }

    public class Button: Component
    {

    }

    public class Panel: Container
    {
        public string ModalHelpText { get; set; }

        public override void ShowHelp()
        {
            if (!string.IsNullOrEmpty(ModalHelpText))
            {
                Console.WriteLine(ModalHelpText);
            }
            else
            {
                base.ShowHelp();
            }
        }
    }

    public class Dialog: Container
    {
        public string WikiPageURL { get; set; }

        public override void ShowHelp()
        {
            if (!string.IsNullOrEmpty(WikiPageURL))
            {
                Console.WriteLine(WikiPageURL);
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}

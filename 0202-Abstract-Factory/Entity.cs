using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0202_Abstract_Factory
{
    public class Button
    {

    }

    public class WinButton: Button
    {

    }

    public class MacButton: Button
    {

    }

    public class CheckBox
    {

    }

    public class WinCheckBox: CheckBox
    {

    }

    public class MacCheckBox: CheckBox
    {

    }

    public interface GUIFactory
    {
        public Button CreateButton();

        public CheckBox CreateCheckBox();
    }

    public class DefaultGUIFactory: GUIFactory
    {
        public Button CreateButton()
        {
            return new Button();
        }

        public CheckBox CreateCheckBox()
        {
            return new CheckBox();
        }
    }

    public class WinGUIFactory:GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }

    public class MacGUIFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}

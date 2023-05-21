using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0402_Command
{
    public class Editor
    {
        public string Text { get; set; }

        public void GetSelection()
        {

        }

        public void DeleteSelection()
        {

        }

        public void ReplaceSelection(string text)
        {
            Text = text;
        }
    }

    public abstract class Command
    {
        public string App { get; set; }

        public Editor Editor { get; set; }

        public string BackUp { get; set; }

        public Command(string app, Editor editor)
        {
            App = app;
            Editor = editor;
        }

        public void SaveBackup()
        {

        }

        public void Undo()
        {

        }

        public abstract void execut();
    }
}

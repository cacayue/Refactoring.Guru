using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0402_Command
{
    public class Editor
    {
        private string _text { get; set; }

        public Editor(string text)
        {
            _text = text;
        }

        public string GetSelection()
        {
            return _text;
        }

        public void DeleteSelection()
        {
            _text = "";
        }

        public void ReplaceSelection(string text)
        {
            _text = text;
        }
    }

    public abstract class Command
    {
        public Application App { get; set; }

        public Editor Editor { get; set; }

        public string BackUp { get; set; }

        public Command(Application app, Editor editor)
        {
            App = app;
            Editor = editor;
            BackUp = "";
        }

        protected virtual void SaveBackup()
        {
            BackUp = Editor.GetSelection();
        }

        protected virtual void Undo()
        {
            Editor.ReplaceSelection(BackUp);
        }

        public abstract bool Execut();
    }

    #region Commands

    public class CopyCommand : Command
    {
        public Editor? Temp { get; set; }

        public CopyCommand(Application app, Editor editor) : base(app, editor)
        {

        }

        public override bool Execut()
        {
            SaveBackup();

            App.Clipboard = Editor.GetSelection();

            return false;
        }
    }

    public class CutCommand : Command
    {

        public CutCommand(Application app, Editor editor) : base(app, editor)
        {

        }

        public override bool Execut()
        {
            SaveBackup();

            App.Clipboard = Editor.GetSelection();

            Editor.DeleteSelection();

            return true;
        }
    }

    public class PasteCommand : Command
    {
        public Editor? Temp { get; set; }

        public PasteCommand(Application app, Editor editor) : base(app, editor)
        {

        }

        public override bool Execut()
        {
            SaveBackup();

            Editor.ReplaceSelection(App.Clipboard);

            return true;
        }
    }

    public class UndoCommand : Command
    {
        public CommandHistory CommandHistory { get; set; }

        public UndoCommand(Application app, Editor editor,CommandHistory commandHistory) : base(app, editor)
        {
            CommandHistory = commandHistory;
        }

        public override bool Execut()
        {
            var oldCommand = CommandHistory.Pop();

            if (oldCommand != null)
            {
                this.BackUp = oldCommand.BackUp;
            }

            Undo();

            return false;
        }
    }

    #endregion

    public class CommandHistory
    {
        private Queue<Command> Commands { get; set; } = new Queue<Command>();

        public void Push(Command command)
        {
            Commands.Enqueue(command);
        }

        public Command Pop()
        {
            return Commands.Dequeue();
        }
    }

    public class Application
    {
        public List<Editor> Editors { get; set; }

        public Editor ActiveEditor { get; set; }

        public string Clipboard { get; set; }

        public CommandHistory History { get; set; }

        public Application()
        {
            Editors = new List<Editor>();
            History = new CommandHistory();
            Clipboard = "";
        }

        public void ExecuteCommand(Command command)
        {
            CacheEditor(command.Editor);
            var res = command.Execut();
            if (res)
            {
                History.Push(command);
            }
        }

        public void Undo()
        {
            var undo = new UndoCommand(this, ActiveEditor, History);
            ExecuteCommand(undo);
        }

        private void CacheEditor(Editor editor)
        {
            Editors.Add(editor);
            ActiveEditor = editor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class KeyboardMove
    {
        ICommand command;

        public KeyboardMove() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public string PressButton()
        {
            return command.Execute();
        }
        public string PressUndo()
        {
            return command.Undo();
        }
    }
}

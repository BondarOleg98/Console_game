using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class KeyboardTake
    {
        ICommand command;

        public KeyboardTake() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public string TakeButton()
        {
            return command.Execute();
        }
        public string PutButton()
        {
            return command.Undo();
        }
    }
}

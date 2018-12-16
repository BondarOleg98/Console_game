using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class KeyboardAction
    {
        ICommandAction command;

        public KeyboardAction() { }

        public void SetCommand(ICommandAction com)
        {
            command = com;
        }
        public string TakeButton()
        {
            return command.Execute();
        }
    }
}

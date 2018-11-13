using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Move : ICommand
    {
        Robot move;
        public Move(Robot mv)
        {
            move = mv;
        }
        public string Execute()
        {
            return move.MoveRight();
        }
        public string Undo()
        {
            return move.MoveLeft();
        }
    }
}

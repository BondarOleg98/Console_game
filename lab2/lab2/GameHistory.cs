using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class GameHistory
    {
        public Stack<RobotMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<RobotMemento>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class Robot
    {

        public string MoveRight()
        {
            return "Move right";
        }
        public string MoveLeft()
        {
            return "Move left";
        }
        public string Take()
        {
            return "Take the package";
        }
        public string Put()
        {
            return "Put the package";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class CreateCleverBot : CreateRobot
    {
        public CreateCleverBot()
        { }
        public override Robot Create()
        {
            return new CleverBot();
        }
    }
}

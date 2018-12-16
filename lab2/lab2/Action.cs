using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Action : ICommandAction
    {
        Robot take;
        public Action(Robot take_action)
        {
            take = take_action; 
        }
        public string Execute()
        {
            return take.Take();
        }
        //public string Undo()
        //{
        //    return take_put.Put();
        //}
    }
}

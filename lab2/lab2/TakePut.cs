using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class TakePut : ICommand
    {
        Robot take_put;
        public TakePut(Robot tp)
        {
            take_put = tp; 
        }
        public string Execute()
        {
            return take_put.Take();
        }
        public string Undo()
        {
            return take_put.Put();
        }
    }
}

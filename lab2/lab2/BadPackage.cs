using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class BadPackage : Package
    {
        public int TakeBadPackage()
        {
            int bad_flag = 0;
            Random random = new Random();
            bad_flag = random.Next(0, 1);
            return bad_flag;
        }
    }
}

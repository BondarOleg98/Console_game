using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class DangerPackage : Package
    {
        public int TakeCharge(int charge)
        {
            Random random = new Random();
            int take_health = 0;
            take_health = random.Next(10,20);
            charge = charge - take_health;
            return charge;
        }
    }
}

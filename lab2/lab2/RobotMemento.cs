using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class RobotMemento
    {
        public int Battery_charge { get; private set; }
        public int Weight_package { get; private set; }
        public int Cost_package { get; private set; }
        
        public RobotMemento(int battert_charge, int weight, int cost)
        {
            this.Battery_charge = battert_charge;
            this.Weight_package = weight;
            this.Cost_package = cost;
        }
    }
}

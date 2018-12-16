using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class SamplePackage : Package
    {
        public SamplePackage() : base("Package")
        { }

        Random random = new Random();
       

        public override int GetCost()
        {       
            return random.Next(15, 25);
        }
        public override int GetWeight()
        {
            return random.Next(10, 40);
        }
        public override int TotalMoney(int money)
        {
            return GetCost() + money;
        }
        public override int TotalWeight(int current_weight)
        {
            return GetWeight() + current_weight;
        }
    }
}

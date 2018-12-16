using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class BadPackage : PackageDecorator
    {
        public BadPackage(Package package) : base( "Bad " + package.Name, package)
        { }
        public override int GetCost()
        {
            return 0;
        }
        public override int GetWeight()
        {
            return 0;
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

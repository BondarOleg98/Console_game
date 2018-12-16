using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class DecoderPackage : PackageDecorator
    {
        Random random = new Random();
        public DecoderPackage(Package package) : base("Decoder "+package.Name, package)
        { }
        public override int GetCost()
        {
            return package.GetCost() + 20;
        }
        public override int GetWeight()
        {
            return package.GetWeight() + 1;
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

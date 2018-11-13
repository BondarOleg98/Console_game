using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Package
    {
        Random random = new Random();
        private int CostPackage = 0;
        private int WeightPackage = 0;

        public int Weight()
        {
            WeightPackage = random.Next(10, 40);
            return WeightPackage;
        }
        public int Cost()
        {
            CostPackage = random.Next(15, 25);
            return CostPackage;
        } 
      

    }
}

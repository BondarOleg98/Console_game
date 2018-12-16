using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Package
    {
        public string Name { get; protected set; }
        public abstract int GetCost();
        public abstract int GetWeight();
        public abstract int TotalMoney(int money);
        public abstract int TotalWeight(int current_weight);
        public Package(string name)
        {
            Name = name;
        }
        public int Decoding(int robot)
        {
            Random random = new Random();
            int decode_flag = 0;
            double decoding = 0;
            decoding = random.NextDouble();
            switch (robot)
            {
                case 1:
                    if (decoding < 0.1)
                    {
                        decode_flag = 1;
                    }
                    break;
                case 2:
                    if (decoding < 1)
                    {
                        decode_flag = 1;
                    }
                    break;
                case 3:
                    if (decoding < 0.6)
                    {
                        decode_flag = 1;
                    }
                    break;

            }
            return decode_flag;
        }
        public int TakeCharge(int charge)
        {
            Random random = new Random();
            int take_health = 0;
            take_health = random.Next(10, 20);
            charge = charge - take_health;
            if (charge < 0)
            {
                charge = 0;
            }
            return charge;
        }
    }
}

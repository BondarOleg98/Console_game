using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Cyborg : Robot
    {
        private int count_step = 0;
        private int load = 0;
        private int current_load = 0;
        private int money = 0;
        private int charge = 100;

        private int package_flag = 0;
        public Cyborg()
        {
            RobotLegend();
        }
        public string RobotLegend()
        {
            Guid unique = Guid.NewGuid();

            string output_legend = "Your bot is cyborg\n" +
                "Unique code: " + unique + "\nHistory:" +
                "\navatar:-\nname: Cyborg\n" +
            "vulnerabilities: can burn, get sick after 28 steps\n" +
            "opportunities: max weight 35 kg, charge - 100%\n" +
            "decoding: 60%\n" +
            "----------------------------------------------------" +
            "\nMove - button left, right  Restore - button down   Exit - q";
            return output_legend;
        }
  
        public string LostEnergyMove()
        {
            string result = "0";
            if (charge == 0)
            {
                result = "0";
                return result;
            }
            else
                charge--;
            result = "Money: " + money + " Weight: "
                        + load + " Charge: " + charge;
            return result;
        }
        public string WeightEnergy()
        {
            string result = "0";
            int decode_flag = 0;
            int middle = 0;
            double bad_state = 0;
            Random random = new Random();
            package_flag = random.Next(1, 4);
            Package package = new SamplePackage();
            switch (package_flag)
            {
                case 1:
                    package = new BadPackage(package);
                    money = package.TotalMoney(money);
                    if (charge <= 0)
                    {
                        charge = 0;
                        result = "0";
                        return result;
                    }
                    result = package.Name + "\nMoney: " + money + " Weight: "
                        + load + " Charge: " + charge;
                    return result;

                case 2:
                    package = new DecoderPackage(package);
                    decode_flag = package.Decoding(3);
                    money = package.TotalMoney(money);

                    current_load = package.GetWeight();

                    if (decode_flag == 0)
                    {
                        result = "Decoding is not success";
                        break;
                    }

                    if (current_load > 35)
                    {
                        result = "Your weight more than 35 kg";
                        return result;
                    }
                    money = package.TotalMoney(money);
                    load = package.TotalWeight(load);

                    count_step++;
                    if (current_load <= 5)
                        charge -= 2;
                    else if (current_load <= 20)
                        charge -= 4;
                    else
                        charge -= 5;

                    if (charge <= 0)
                    {
                        charge = 0;
                        result = "0";
                        return result;
                    }

                    middle = load / count_step;
                    if (middle >= 28)
                    {
                        bad_state = random.NextDouble();
                        if (bad_state < 0.3)
                        {
                            charge -= 10;
                        }
                    }

                    result = package.Name + "\nMoney: " + money + " Weight: "
                        + load + " Charge: " + charge;
                    break;

                case 3:
                    package = new DangerPackage(package);
                    money = package.TotalMoney(money);
                    charge = package.TakeCharge(charge);
                    if (charge <= 0)
                    {
                        charge = 0;
                        result = "0";
                        return result;
                    }
                    result = package.Name + "\nMoney: " + money + " Weight: "
                        + load + " Charge: " + charge;
                    return result;
            }

            return result;
        }
        public string Progress()
        {
            string result;
            result = "\nMoney: " + money + " Weight: "
                        + load + " Charge: " + charge;
            return result;
        }

        public RobotMemento SaveState()
        {
            return new RobotMemento(charge, load, money);
        }
        public string RestoreState(RobotMemento memento)
        {
            string result = "0";
            charge = memento.Battery_charge;
            load = memento.Weight_package;
            money = memento.Cost_package;
            result = "Restore game: money - " + money + ", weight - " + load + " ,charge - " + charge;
            return result;
        }
    }
}

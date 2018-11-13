using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class DecoderPackage : Package
    {
        public int Decoding(int robot)
        {
            int decode_flag = 0;
            double decoding = 0;
            Random random = new Random();
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
    }
}

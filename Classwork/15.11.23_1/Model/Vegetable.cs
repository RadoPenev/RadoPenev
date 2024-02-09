using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._11._23_1
{
    class Vegetable
    {
        public double PricePerVeg { get; set; }
        public double PricePerFruit { get; set; }
        public int KillogramVeg { get; set; }
        public int KillogramFruit { get; set; }

      public double Total()
        {
            return ((PricePerVeg * KillogramVeg) + (PricePerFruit * KillogramFruit)) / 1.94;
        }

        public Vegetable(double priceperveg,double priceperfruit,int killoveg,int killofruit)
        {
            PricePerVeg = priceperveg;
            PricePerFruit = priceperfruit;
            KillogramVeg = killoveg;
            KillogramFruit = killofruit;
        }
    }
}

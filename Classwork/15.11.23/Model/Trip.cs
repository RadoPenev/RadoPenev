using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._11._23
{
    class Trip
    {
       

        public int Killometers { get; set; }
        public string Time { get; set; }

        public double Travel()
        {
         
            if (Killometers<20)
            {
                if (Time.ToLower()=="day")
                {
                   return (0.7 + (Killometers * 0.79));
                }
                else
                {
                    return (0.7 + (Killometers * 0.90));
                }
            }
            else if (Killometers>=20 && Killometers<100)
            {
                return (Killometers * 0.09);
            }
            else
            {
                return (Killometers * 0.06);
            }
        }


        public Trip(int killometers,string time)
        {
            Killometers = killometers;
            Time = time;
        }
    }
}

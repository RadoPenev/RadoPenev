using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._11._23
{
    class Tip
    {
        private double ammount;
        private double percent;

        public double Ammount {
             
            get 
            { 
                return ammount; 
            } 
            set 
            { 
                ammount = value;
            } 
        }
        public double Percent {
            get 
            {
                return percent;
            }
            set 
            {
                if (value > 1)
                {
                    value /= 100;
                }
                percent = value;
            } 
        }

        public double CalculateTip()
        {
            return ammount * percent;
        }

        public double CalculateTotal()
        {
            return ammount + CalculateTip();
        }


        public Tip(double ammount, double percent)
        {
            Ammount = ammount;
            Percent = percent;
        }
    }
}

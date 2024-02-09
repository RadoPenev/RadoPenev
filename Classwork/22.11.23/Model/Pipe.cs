using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._23
{
    class Pipe
    {
        public double Volume { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Hours { get; set; }

        public Pipe(double volume,double p1,double p2,double hours)
        {
            Volume = volume;
            P1 = p1;
            P2 = p2;
            Hours = hours;
        }

        public List<double> CalculatePercents()
        {
            List<double> info = new List<double>();
            P1 *= Hours;
            P2 *= Hours;
            double zapulneniLitri = P1 + P2;
            double percents = zapulneniLitri / Volume * 100;
            double P1Percents = P1 / zapulneniLitri * 100;
            double P2Percents = P2 / zapulneniLitri * 100;
            if (zapulneniLitri > Volume)
            {
                info.Add(Hours);
                info.Add(zapulneniLitri - Volume);
                return info;
            }
            else
            {
                info.Add(percents);
                info.Add(P1Percents);
                info.Add(P2Percents);
                return info;
            }
        }
    }
}

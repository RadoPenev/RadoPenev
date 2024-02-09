using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._23_4
{
    class Holiday
    {
        public double Budget { get; set; }
        public string Season { get; set; }

        public Holiday(double budget,string season)
        {
            Budget = budget;
            Season = season;
        }

        public string Spend()
        {
            double spend=0;
            string where="";
            string location="";
            if (Season.ToLower()=="summer")
            {
                if (Budget<=100)
                {
                    spend= Budget * 0.3;
                    where = "Camp";
                    location = "Bulgaria";
                }
                if (Budget<=1000)
                {
                    spend=Budget * 0.4;
                    where = "Camp";
                    location = "Balkans";
                }
            }
            else if(Season.ToLower()=="winter")
            {
                if (Budget<=100)
                {
                    spend= Budget * 0.7;
                    where = "Hotel";
                    location = "Bulgaria";
                }
                if (Budget <= 1000)
                {
                    spend=Budget * 0.8;
                    where = "Hotel";
                    location = "Balkans";
                }
            }
            else
            {
                spend= Budget * 0.9;
                where = "Hotel";
                location = "Europe";
            }

            return $"Somwhere in {location} " +
                $"{where} - {spend}";
        }


    }
}

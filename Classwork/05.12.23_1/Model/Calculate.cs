using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05._12._23_1
{
    internal class Calculate
    {
        public int N { get; set; }
        public string[] info;
        public double HearhStone { get; set; }
        public double Fortnite { get; set; }
        public double Overwatch { get; set; }
        public double Others { get; set; }


        public Calculate(int n, string[] info)
        {
            N = n;
            this.info = info;
        }
        public void Percentages()
        {
            int br1 = 0;
            int br2 = 0;
            int br3 = 0;
            int br4 = 0;
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i].ToLower() == "hearthstone")
                {
                    br1++;
                }
                else if (info[i].ToLower() == "fortnite")
                {
                    br2++;
                }
                else if (info[i].ToLower() == "overwatch")
                {
                    br3++;
                }
                else
                {
                    br4++;
                }
            }
            HearhStone = (double)br1 / info.Length * 100;
            Fortnite = (double)br2 / info.Length * 100;
            Overwatch = (double)br3 / info.Length * 100;
            Others = (double)br4 / info.Length * 100;
        }
    }
}
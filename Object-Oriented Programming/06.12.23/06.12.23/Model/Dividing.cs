using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._12._23
{
    internal class Dividing
    {
        public int N { get; set; }
        public double[] Input { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public Dividing(int n, double[] input) { N = n;Input = input; }

        public void Calculating()
        {
            int br1 = 0;
            int br2 = 0;    
            int br3 = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i]%2==0)
                {
                    br1++;
                }
                if (Input[i]%3==0)
                {
                    br2++;
                }
                if (Input[i]%4==0)
                {
                    br3++;
                }
            }
            P1 = (double)br1 / Input.Length * 100;
            P2= (double)br2 / Input.Length * 100;
            P3= (double)br3 / Input.Length * 100;

        }
    }
}

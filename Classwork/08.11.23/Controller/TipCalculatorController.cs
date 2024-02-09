using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._11._23
{
    class TipCalculatorController
    {
        Tip tip;
        Display display;

        public TipCalculatorController()
            {
            display = new Display();
            tip = new Tip(display.Ammount,display.Percent);
            display.Tipp = tip.CalculateTotal();
            display.Total = tip.CalculateTotal();
            display.Print();
            }
    }
}

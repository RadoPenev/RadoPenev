using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._12._23
{
    internal class DividingController
    {
        Display display;
        Dividing dividing;

        public DividingController() 
        {
            display = new Display();
            dividing = new Dividing(display.N,display.Input);
            dividing.Calculating();
            display.P1=dividing.P1;
            display.P2=dividing.P2;
            display.P3=dividing.P3;
            
            display.Print();
        }
    }
}

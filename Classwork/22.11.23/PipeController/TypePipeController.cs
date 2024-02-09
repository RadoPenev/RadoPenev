using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._23
{
    class TypePipeController
    {
        Display display;
        Pipe pipe;

        public TypePipeController()
        {
            display = new Display();
            pipe = new Pipe(display.Volume,display.P1,display.P2,display.H);

            display.Info = pipe.CalculatePercents();
            display.Print();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._23_4
{
    class TypeHolidayController
    {
        Display display;
        Holiday holiday;

        public TypeHolidayController()
        {
            display = new Display();
            holiday = new Holiday(display.Budget,display.Season);

            display.PrintEvrt = holiday.Spend();
            display.Print();
        }
    }
}

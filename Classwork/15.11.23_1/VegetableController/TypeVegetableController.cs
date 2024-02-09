using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._11._23_1
{
    class TypeVegetableController
    {
        Vegetable vegetable;
        Display display;

        public TypeVegetableController()
        {
            display = new Display();
            vegetable = new Vegetable(display.PricePerVeg, display.PricePerFruit, display.KillogramVeg, display.KillogramFruit);

            display.Cost = vegetable.Total();
            display.Print();
        }
    }
}

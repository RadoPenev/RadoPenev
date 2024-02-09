using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._11._23
{
    class TripVehicleController
    {
        Trip trip;
        Display display;

       public TripVehicleController()
        {
            display = new Display();
            trip = new Trip(display.Killometers,display.Time);
          
            display.Cost = trip.Travel();
            display.Print();
        }
    }
}

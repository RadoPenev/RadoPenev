using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        public interface IVehicle
        {
             double fuelQuantity { get; set; }
             double fuelConsumption { get; set; }

            void DHhedhey();
        }

      /*  public class Car : IVehicle
        {
            public double fuelQuantity { get; set; }
            public double fuelConsumption { get; set; }


        }*/


        static void Main(string[] args)
        {
        }
    }
}

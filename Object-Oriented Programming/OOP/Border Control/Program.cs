using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control
{
    class Program
    {
        public interface IPerson
        {
            string Name { get; set; }
            int Age { get; set; }
        }

        public interface IID
        {
            string ID { get; set; }
        }
        public interface IRobot
        {
            string Model { get; set; }
            string ID { get; set; }
        }

        public class Citizen : IPerson, IID
        {

        }

        static void Main(string[] args)
        {
        }
    }
}

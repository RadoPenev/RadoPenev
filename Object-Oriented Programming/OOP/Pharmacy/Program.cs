using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class Medicine
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public Medicine(string n, double p)
        {
            Name = n;
            Price = p;
        }

        public void Print()
        {
            Console.WriteLine($"Name:{Name} Price:{Price}");
        }
    }
    class Pharmacy
    {
        public string Name { get; set; }
        List<Medicine> pharmacies = new List<Medicine>();

        public Pharmacy(string n)
        {
            Name = n;
        }
        public void Order(Medicine medicine)
        {
            pharmacies.Add(medicine);
        }
        public bool Sell(Medicine medicine)
        {
            bool check = false;
            foreach (var item in pharmacies)
            {
                if (item.Equals(medicine))
                {
                    pharmacies.Remove(item);
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        public double Total()
        {
            double total = 0;
            foreach (var item in pharmacies)
            {
                total += item.Price;
            }
            return total;
        }
        public void Rename(string n)
        {
            Name = n;
        }
        public void Sellall()
        {
            pharmacies.Clear();
        }
        public void Max()
        {
            pharmacies.OrderByDescending(Price)
        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(pharmacies.Count);
            foreach (var item in pharmacies)
            {
                item.Print();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy("Nigga");


        }
    }
}

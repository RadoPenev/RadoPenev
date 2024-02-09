using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        private string name;
        private double price;
        public string Name
        {
            get { return name; }
            set
            {
                if (name.Length<3)
                {
                    throw new ArgumentException("Invalid product name!");
                }
                else
                {
                    name = value;
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price<0.00)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                else
                {
                    price = value;
                }
            }
        }

        public bool Promotion { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Promotion = false;
        }

        public Product(string name, double price, bool isOnPromotion)
        {
            Name = name;
            Price = price;
            Promotion = true;
        }

        public override string ToString()
        {
            string yOn;
            if (Promotion==false)
            {
                yOn = "No";
            }
            else
            {
                yOn = "Yes";
            }
            return $"Product -> {Name} with price {Price}. On promotion {yOn}";
        }
    }
}

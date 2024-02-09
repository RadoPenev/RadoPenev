using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Product
    {
        private string productName;
        private string barcode;
        private double price;
        private double quantity;
        public string ProductName { get { return this.productName; } set { this.productName = value; } }
        public string Barcode { get { return this.barcode; } set { this.barcode = value; } }
        public double Price { get { return this.price; } set { this.price = value; } }
        public double Quantity
        {
            get { return this.quantity; }
            set
            {
                this.quantity = value;
            }
        }
        public Product(string name, string code, double price1, double quantity1)
        {
            ProductName = name;
            Barcode = code;
            Price = price1;
            Quantity = quantity1;
        }
    }
}

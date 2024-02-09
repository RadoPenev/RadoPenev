using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Magazine
    {
        private static List<Product> productList = new List<Product>();
        public static void Add(string code, string name, double price, double quantity)
        {
            Product newProduct = new Product(name, code, price, quantity);
            productList.Add(newProduct);
        }
        public static void Update(string code, double quantity)
        {

            foreach (var item in productList)
            {
                if (item.Barcode == code)
                {
                    item.Quantity += quantity;
                    break;
                }
                else
                {
                    Console.WriteLine("Please add your product first!");
                };
            }

        }
        public static void Sell(string code, double quantity)
        {
            foreach (var item in productList)
            {
                if (item.Barcode == code)
                {
                    if (item.Quantity >= quantity)
                    {
                        item.Quantity -= quantity;
                    }
                    else
                    {
                        Console.WriteLine("Not enough quantity");
                    }

                }

                else
                {
                    Console.WriteLine("Please add your product first!");
                }

            }
        }
    }
}

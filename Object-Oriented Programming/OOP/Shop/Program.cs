using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            while (input[0].ToLower()!="end")
            {
                switch (input[0].ToLower())
                {
                    case "CreateProduct":

                        AddProduct(input[1], double.Parse(input[2]),bool.Parse(input[3]));

                        break;

                    case "GetOrderTotalPrice":

                        GetOrderTotalPrice();

                        break;

                    case "GetDiscountedProductsTotalPrice":

                        GetDiscountedProductsTotalPrice();

                        break;

                    case "GetDiscountedProductsCount":

                        GetDiscountedProductsCount();

                        break;

                }
                input = Console.ReadLine().Split(' ');
            }
        }

       static List<Product> products = new List<Product>();
       static Order order = new Order(14123123,products);

        private static void AddProduct(string name, double price,bool promotion)
        {
            order.AddProduct(name, price,promotion);

        }

        private static double GetOrderTotalPrice()
        {
           return order.GetOrderTotalPrice();
        }

        private static double GetDiscountedProductsTotalPrice()
        {
            return order.GetDiscountedProductsTotalPrice();
        }

        private static int GetDiscountedProductsCount()
        {
            return order.GetDiscountedProductsCount();
        }

        /*
CreateProduct AirPods 149.90 
CreateProduct IphoneX 149.90 true 
CreateProduct IphoneXR 149.90 false 
CreateOrder 333333 IphoneX 
AddToOrder 333333 AirPods 
GetOrderTotalPrice 333333 
GetOrderDiscountedProductsPrice 333333 
GetOrderDiscountedProductsCount 333333 
PrintProductInfoByName IphoneX 
PrintOrderByNumber 333333 
End */

    }
}

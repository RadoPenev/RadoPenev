using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Order
    {
        public static int Ordercount
        {
            get;set;
        }

        public int OrderNumber { get; set; }
        public List<Product> ProductList { get; set; }
        public Order(int orderNumber, List<Product> productsList)
        {
            OrderNumber = orderNumber;
            ProductList = productsList;
        }


        public void AddProduct(string name,double price,bool promotion)
        {
            Product product = new Product(name,price,promotion);
            ProductList.Add(product);
      
        }



        public double GetOrderTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < ProductList.Count; i++)
            {
                sum += ProductList[i].Price;
            }

            return sum;
        }



        public double GetDiscountedProductsTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].Promotion==true)
                {
                    sum += ProductList[i].Price;
                }
            }
            return sum;
        }



        public int GetDiscountedProductsCount()
        {
            int count = 0;
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].Promotion == true)
                {
                    count++;
                }
            }
            return count;
        }



        public override string ToString()
        {
            return $"Order #{OrderNumber} has the following products:";
        }

    }
}

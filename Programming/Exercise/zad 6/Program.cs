using System;
using System.Collections.Generic;
namespace zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> info = new Dictionary<string, Dictionary<string, double>>();
            double total = 0;

            string[] row = Console.ReadLine().Split(' ');
            while (row[0].ToLower()!="stocked")
            {
                string productName = row[0];
                if (info.ContainsKey(productName))
                {

                    var item = info[productName];
                    item["Price"] = Double.Parse(row[1], System.Globalization.CultureInfo.InvariantCulture);
                    item["Quantity"] += Double.Parse(row[2], System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    info.Add(
                        row[0],
                        new Dictionary<string, double>
                        {
                            {"Price", Double.Parse(row[1], System.Globalization.CultureInfo.InvariantCulture) },
                            {"Quantity", Double.Parse(row[2], System.Globalization.CultureInfo.InvariantCulture) }
                        });
                }
                row = Console.ReadLine().Split(' ');
            }

            foreach (var item in info)
            {
                var value = item.Value;
                double sum = value["Price"] * value["Quantity"];
                total += sum;

                Console.WriteLine(String.Format("{0}: ${1:N2} * {2:0.##} = ${3:N2}", item.Key, value["Price"], value["Quantity"], sum));
            }
            Console.WriteLine("=====================================");
            Console.WriteLine(String.Format("Grand Total: ${0:N2}", total));
        }


    }
}

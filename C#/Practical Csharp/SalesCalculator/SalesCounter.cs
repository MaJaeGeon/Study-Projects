using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SalesCalculator
{
    public class SalesCounter
    {
        private IEnumerable<Sale> _sales;

        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }

        public IDictionary<string, int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();

            foreach(var sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }

            return dict;
        }

        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            var sales = new List<Sale>();

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var items = line.Split(',');

                sales.Add(new Sale { ShopName = items[0], ProductCategory = items[1], Amount = int.Parse(items[2]) });
            }

            return sales;
        }
    }
}

using System;
using System.Collections.Generic;

namespace SalesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter("sales.csv");
            var amountPerStore = sales.GetPerStoreSales();

            foreach (var obj in amountPerStore)
                Console.WriteLine($"{obj.Key} {obj.Value}");

        }
    }
}

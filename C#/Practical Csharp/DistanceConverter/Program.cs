using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1 && args[0] == "-tom") PrintFeetToMeterList(1, 10);
            else PrintMeterToFeetList(1, 10);
        }

        private static void PrintFeetToMeterList(int begin, int end)
        {
            for(int feet = begin; feet <= end; feet++)
            {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine($"{feet} ft = {meter.ToString("0.0000")} m");
            }
        }

        private static void PrintMeterToFeetList(int begin, int end)
        {
            for (int feet = begin; feet <= end; feet++)
            {
                double meter = FeetConverter.FromMeter(feet);
                Console.WriteLine($"{feet} ft = {meter.ToString("0.0000")} m");
            }
        }
    }
}

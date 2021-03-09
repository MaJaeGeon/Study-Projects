namespace DistanceConverter
{
    public static class FeetConverter
    {
        private const double _ratio = 0.3048;

        public static double FromMeter(double meter)
        {
            return meter / _ratio;
        }

        public static double ToMeter(double meter)
        {
            return meter * _ratio;
        }
    }
}
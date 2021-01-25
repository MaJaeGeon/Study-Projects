using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Binding
{
    /// <summary>
    /// Interaction logic for ValueConverter.xaml
    /// </summary>
    public partial class ValueConverter : Window
    {
        public ValueConverter()
        {
            InitializeComponent();
        }
    }


    [ValueConversion(typeof(int), typeof(Brush))]
    public class AgeToBrush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(Brush)) return null;

            int age = int.Parse(value.ToString());

            if (age < 20) return Brushes.Red;
            else return Brushes.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
            //throw new NotImplementedException();
        }
    }

    [ValueConversion(typeof(int), typeof(string))]
    public class HexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int result = int.Parse(value.ToString());
            return result.ToString("X");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return int.Parse(value.ToString(), NumberStyles.HexNumber);
        }
    }
}

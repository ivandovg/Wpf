using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Wpf4
{
    public class ProductCountRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int count;
            if ((value == null) | !int.TryParse(value.ToString(), out count))
                return new ValidationResult(false, "Is not a number");
            if (count <= 0)
                return new ValidationResult(false, "Cannot be less than 0");

            return new ValidationResult(true, null);
        }
    }

    public class ProductCostRule : ValidationRule
    {
        public double MinProductCost { get; set; } = 0;
        //public ProductCostRule()
        //{
        //    MinProductCost = 0;
        //}
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double cost;
            if ((value == null) | !double.TryParse(value.ToString(), out cost))
                return new ValidationResult(false, "Is not a number");
            if (cost <= MinProductCost)
                return new ValidationResult(false, "Cannot be less than 0");

            return new ValidationResult(true, null);
        }
    }

    [ValueConversion(typeof(int), typeof(Brush))]
    public class DoubleToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value > 5 ? Brushes.Blue : Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

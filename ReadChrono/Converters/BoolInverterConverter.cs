using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ReadChrono.Converters
{
    public class BoolInverterConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value is bool boolvalue)
            {
                return !boolvalue;
            }
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

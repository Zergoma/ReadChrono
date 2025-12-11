using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ReadChrono.Converters
{
    public class StopWatchToActionTextConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value is bool isrunning)
            {
                if (isrunning)
                {
                    return "Stop";
                }
                else
                {
                    return "Start";
                }
            }
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

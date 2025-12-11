using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ReadChrono.Converters
{
    public class IsRunningToOpacityConverter : IValueConverter
    {
        public bool Inverted { get; set; } = false;

        private double same(bool running)
        {
            return running ? 1.0 : 0.0;
        }

        private double opposite(bool running)
        {
            return running ? 0.0 : 1.0;
        }


        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value is bool isrunning)
            {
                return Inverted ? opposite(isrunning) : same(isrunning);
            }
            return 1.0;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

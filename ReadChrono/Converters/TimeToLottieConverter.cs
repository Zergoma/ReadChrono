using SkiaSharp.Extended.UI.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ReadChrono.Converters
{
    public class TimeToLottieConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is int secondsEllapsed)
            {
                return new SKFileLottieImageSource
                {
                    File = secondsEllapsed switch
                    {
                        <= 0 => "Heart.json",
                        <= 5 => "Rocket.json",
                        <= 10 => "Plane.json",
                        <= 15 => "Helicopter.json",

                        <= 20 => "Vespa.json",
                        <= 25 => "Car.json",
                        <= 30 => "Bus.json",
                        <= 35 => "Tractor.json",
                        _ => "Roller.json",
                    }
                };
            }
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

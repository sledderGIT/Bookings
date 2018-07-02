using System;
using System.Globalization;
using System.Linq;
using MvvmCross.Converters;

namespace Bookings.Core.Converters
{
    public class CapitalizeValueConverter: MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo cultureInfo)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            return value.First().ToString().ToUpper() + value.Substring(1);
        }
    }
}

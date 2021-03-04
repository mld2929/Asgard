using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Asgard.Converters
{
    internal class ObjectToVisibilityConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is string str)
                return !string.IsNullOrWhiteSpace(str) ? Visibility.Visible : Visibility.Collapsed;

            return value != null ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }

        #endregion Methods
    }
}
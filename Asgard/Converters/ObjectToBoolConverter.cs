using System;
using System.Globalization;
using System.Windows.Data;

namespace Asgard.Converters
{
    internal class ObjectToBoolConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }

        #endregion Methods
    }
}
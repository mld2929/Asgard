using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

using Asgard.ViewModels;

using AsgardFramework.WoWAPI;

namespace Asgard.Converters
{
    internal class GameWrapperToGameInfoConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return value switch {
                IEnumerable<IGameWrapper> games => games.Select(g => new GameInfoViewModel(g)),
                IGameWrapper game => new GameInfoViewModel(game),
                _ => throw new ArgumentException($"Value was {value.GetType()}", nameof(value))
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }

        #endregion Methods
    }
}
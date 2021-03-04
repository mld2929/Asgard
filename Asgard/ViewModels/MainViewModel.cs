using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;

using Asgard.Views;

using AsgardFramework.WoWAPI;
using AsgardFramework.WoWAPI.Implementation;

namespace Asgard.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Properties

        public static MainViewModel Instance { get; } = new MainViewModel();

        public static Command OpenDebugCommand { get; } = new Command(_ => openDebug());
        public static Command OpenLuaCommand { get; } = new Command(id => openLuaOrShowError((int)id));
        public static Command RefreshCommand { get; } = new Command(_ => Instance.OnPropertyChanged(nameof(AvailableGames)));
        public IReadOnlyList<IGameWrapper> AvailableGames => GameWrapper.Games;

        #endregion Properties

        #region Methods

        [Conditional("DEBUG")]
        private static void openDebug() {
            new DebugView().Show();
        }

        private static void openLuaOrShowError(int id) {
            var api = GameWrapper.Games.FirstOrDefault(g => g.ID == id)
                                 ?.GameAPIFunctions;

            if (api == null) {
                MessageBox.Show("Selected process not found", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Instance.OnPropertyChanged(nameof(AvailableGames));
            } else {
                new LuaView(new LuaViewModel(api)).Show();
            }
        }

        #endregion Methods
    }
}
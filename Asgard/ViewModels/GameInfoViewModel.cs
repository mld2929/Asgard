using AsgardFramework.WoWAPI;

namespace Asgard.ViewModels
{
    internal class GameInfoViewModel : ViewModelBase
    {
        #region Constructors

        internal GameInfoViewModel(IGameWrapper game) {
            ProcessId = game.ID;
            getPlayerNameAsync(game);
        }

        #endregion Constructors

        #region Methods

        private async void getPlayerNameAsync(IGameWrapper game) {
            ActivePlayerName = (await game.ObjectManager.GetPlayerAsync()
                                          .ConfigureAwait(false)).Name;

            OnPropertyChanged(nameof(ActivePlayerName));
        }

        #endregion Methods

        #region Properties

        // todo: access name w/o code execution
        public string ActivePlayerName { get; private set; }

        public int ProcessId { get; }

        #endregion Properties
    }
}
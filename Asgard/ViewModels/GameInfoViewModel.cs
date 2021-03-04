using AsgardFramework.WoWAPI;

namespace Asgard.ViewModels
{
    internal class GameInfoViewModel : ViewModelBase
    {
        #region Constructors

        internal GameInfoViewModel(IGameWrapper game) {
            ProcessId = $"ID: {game.ID}";
            ActivePlayer = appendIfNotEmpty("Player: ", game.PlayerName);
            Realm = appendIfNotEmpty("Realm: ", game.CurrentRealm);
            Account = appendIfNotEmpty("Account: ", game.CurrentAccount);
        }

        #endregion Constructors

        #region Methods

        private static string appendIfNotEmpty(string description, string data) {
            return string.IsNullOrWhiteSpace(data) ? data : description + data;
        }

        #endregion Methods

        #region Properties

        public string Account { get; }
        public string ActivePlayer { get; }
        public string ProcessId { get; }
        public string Realm { get; }

        #endregion Properties
    }
}
using AsgardFramework.WoWAPI;

namespace Asgard.ViewModels
{
    public class LuaViewModel : ViewModelBase
    {
        #region Fields

        private readonly IGameAPIFunctions m_api;

        #endregion Fields

        #region Constructors

        internal LuaViewModel(IGameAPIFunctions api) {
            m_api = api;
            ExecuteScriptCommand = new Command(script => m_api.RunScriptAsync((string)script));
        }

        #endregion Constructors

        #region Properties

        public Command ExecuteScriptCommand { get; }

        #endregion Properties
    }
}
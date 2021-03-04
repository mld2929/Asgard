using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Asgard.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged = _EventHandler.Empty.Invoke;

        #endregion Events

        #region Methods

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion Methods
    }
}
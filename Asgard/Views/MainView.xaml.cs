using System.Windows;
using System.Windows.Input;

using Asgard.ViewModels;

namespace Asgard.Views
{
    public partial class MainView : Window
    {
        #region Constructors

        public MainView() {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void onKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Separator)
                MainViewModel.OpenDebugCommand.Execute(null);
        }

        #endregion Methods
    }
}
using System.Windows;

using Asgard.ViewModels;

namespace Asgard.Views
{
    /// <summary>
    ///     Логика взаимодействия для LuaView.xaml
    /// </summary>
    public partial class LuaView : Window
    {
        #region Constructors

        public LuaView(LuaViewModel vm) {
            InitializeComponent();
            DataContext = vm;
        }

        #endregion Constructors
    }
}
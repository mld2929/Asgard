using System;
using System.Windows.Input;

namespace Asgard
{
    public class Command : ICommand
    {
        #region Constructors

        public Command(Action<object> execute, Func<object, bool> canExecute = null) {
            m_canExecute = canExecute;
            m_execute = execute;
        }

        #endregion Constructors

        #region Events

        public event EventHandler CanExecuteChanged = _EventHandler.Empty.Invoke;

        #endregion Events

        #region Fields

        private readonly Func<object, bool> m_canExecute;
        private readonly Action<object> m_execute;
        private bool m_state;

        #endregion Fields

        #region Methods

        public bool CanExecute(object parameter) {
            if (m_state != m_canExecute?.Invoke(parameter)) {
                CanExecuteChanged(this, EventArgs.Empty);
                m_state = !m_state;
            }

            return m_state;
        }

        public void Execute(object parameter) {
            m_execute(parameter);
        }

        #endregion Methods
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DotNetCoreDemo.Code
{
    /// <summary>
    /// Class which relays commands from UI elements to the ViewModel
    /// </summary>
    public class RelayCommand : ICommand
    {
        Action<object> _executemethod;
        Func<object, bool> _canexecutemethod;

        public RelayCommand(Action<object> executemethod, Func<object, bool> canexecutemethod)
        {
            _executemethod = executemethod;
            _canexecutemethod = canexecutemethod;
        }


        public bool CanExecute(object parameter)
        {
            if (_canexecutemethod != null)
            {
                return _canexecutemethod(parameter);
            }
            else
            {
                return false;
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _executemethod(parameter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OpendataLibrary;

namespace OpenDataWPF.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> _toExecute;
        private Func<object, bool> _canExecute;

        public RelayCommand(Action<object> toExcecute, Func<object, bool> canExecute = null)
        {
            _toExecute = toExcecute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute(parameter);
            }

            return true;
        }

        public void Execute(object parameter)
        {
            _toExecute(parameter);
        }

    }
}
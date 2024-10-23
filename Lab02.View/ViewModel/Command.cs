using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab02.View.ViewModel
{
    class Command : ICommand
    {
        public Command(Action<object> action)
        {
            ExecuteDelegate = action;
        }

        public Predicate<object> CanExecuteDelegate { get; set; }
        public Action<object> ExecuteDelegate { get; set; }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return CanExecuteDelegate?.Invoke(parameter) ?? true;
        }

        public void Execute(object? parameter)
        {
            ExecuteDelegate.Invoke(parameter);
        }
    }
}

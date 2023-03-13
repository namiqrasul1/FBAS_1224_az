using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp11.Commands
{
    public class MessageCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => false;

        public void Execute(object? parameter)
        {
            MessageBox.Show("Hakuna Matata");
        }
    }
}

using Calc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calc.Command
{
    public class ButtonCalculateCommand : ICommand
    {
        private PersonViewModel obj; // Point 1
        public ButtonCalculateCommand(PersonViewModel _obj) // Point 2
        {
            obj = _obj;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}

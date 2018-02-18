using Calc.Command;
using Calc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Calc.ViewModel
{
    public class PersonViewModel
    {

        public PersonViewModel()
        {
            this.Calculate = new RelayCommand(obj => MessageBox.Show(obj.ToString()));
        }

        private Person person = new Person();

        public string TxtFirstName
        {
            get { return person.FirstName; }
            set { person.FirstName = value; }
        }

        public string TxtLastName
        {
            get { return person.LastName; }
            set { person.LastName = value; }
        }

       public string TxtMonthlyPreTaxIncome
        {
            get { return person.ActualMonthlyPreTaxIncome.PreTaxIncome.ToString(); }
            set { person.ActualMonthlyPreTaxIncome.PreTaxIncome = decimal.Parse(value);  }
        }

        public string ButtonContent
        {
            get
            {
                return "Berechnen";
            }
        }


        public ICommand Calculate { get; set; }


    }
}

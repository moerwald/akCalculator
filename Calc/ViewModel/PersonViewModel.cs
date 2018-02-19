using Calc.Command;
using Calc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Calc.ViewModel
{
    public class PersonViewModel : ObservableObject
    {

        public PersonViewModel()
        {
            this.Calculate = new RelayCommand(async obj => await GetCalculatedIncomes());
        }

        private async Task GetCalculatedIncomes()
        {
            var values = new Dictionary<string, string>
            {
                { "alleinverdienerabsetzbetrag", "0" },
                { "arbeitsverhaeltnis","1" },
                { "brutto","Brutto:+2.000,00" },
                { "einkommen","0" },
                { "freibetrag","Freibetrag+monatlich:+0,00" },
                { "kinder","Kinder:+0" },
                { "mehrKinder","0" },
                { "pendeltage","3" },
                { "sachbezug","Sachbezug+monatlich:+0,00" },
                { "sachbezugKFZ","0" },
                { "submitAction","submit" },
                { "verkehrsmittel","1" },
                { "wegstrecke","Wegstrecke+in+km:+0,00" },
            };

            var content = new FormUrlEncodedContent(values);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync("http://bruttonetto.arbeiterkammer.at/", content);

                var responseString = await response.Content.ReadAsStringAsync();
                TxtMonthlyPreTaxIncome = "2789";
                MessageBox.Show(responseString);
            }
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
            get { return  $"{person.ActualMonthlyPreTaxIncome.PreTaxIncome.ToString()} €"; }
            set
            {
                person.ActualMonthlyPreTaxIncome.PreTaxIncome = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtMonthlyPreTaxIncome));
            }
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

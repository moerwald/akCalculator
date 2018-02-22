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
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace Calc.ViewModel
{
    public class PersonViewModel : ObservableObject
    {
        public PersonViewModel()
        {
            this.Calculate = new RelayCommand(async obj => await GetCalculatedIncomes());
        }

        private Regex decimalNumberRegex = new Regex(@"(([0-9]\.)?[0-9]*\,[0-9]*)", RegexOptions.Compiled);

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


        #region Incomes

        #region Monthly Income

        public string TxtPreTaxMonthlyIncome
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.MonthlyCredit).PreTaxIncome.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.MonthlyCredit).PreTaxIncome = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtPreTaxMonthlyIncome));
            }
        }

        public string TxtAfterTaxMonthlyIncome
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.MonthlyCredit).AfterTaxIncome.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.MonthlyCredit).AfterTaxIncome = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtAfterTaxMonthlyIncome));
            }
        }

        public string TxtNationalInsuranceMonthlyIncome
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.MonthlyCredit).NationalInsurance.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.MonthlyCredit).NationalInsurance = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtNationalInsuranceMonthlyIncome));
            }
        }

        public string TxtIncomeTaxMonthlyIncome
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.MonthlyCredit).IncomeTax.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.MonthlyCredit).IncomeTax = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtIncomeTaxMonthlyIncome));
            }
        }

        #endregion


        #region Christmas Bonus

        public string TxtPreTaxIncomeChristmasBonus
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.ChristmasBonus).PreTaxIncome.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.ChristmasBonus).PreTaxIncome = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtPreTaxIncomeChristmasBonus));
            }
        }

        public string TxtAfterTaxChristmasBonus
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.ChristmasBonus).AfterTaxIncome.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.ChristmasBonus).AfterTaxIncome = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtAfterTaxChristmasBonus));
            }
        }

        public string TxtNationalInsuranceChristmasBonus
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.ChristmasBonus).NationalInsurance.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.ChristmasBonus).NationalInsurance = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtNationalInsuranceChristmasBonus));
            }
        }

        public string TxtIncomeTaxChristmasBonus
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.ChristmasBonus).IncomeTax.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.ChristmasBonus).IncomeTax = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtIncomeTaxChristmasBonus));
            }
        }

        #endregion


        #region Vacation Bonus

        public string TxtPreTaxIncomeVactionBonus
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.VacationBonus).PreTaxIncome.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.VacationBonus).PreTaxIncome = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtPreTaxIncomeVactionBonus));
            }
        }

        public string TxtAfterTaxVacationBonus
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.VacationBonus).AfterTaxIncome.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.VacationBonus).AfterTaxIncome = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtAfterTaxVacationBonus));
            }
        }

        public string TxtNationalInsuranceVactionBonus
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.VacationBonus).NationalInsurance.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.VacationBonus).NationalInsurance = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtNationalInsuranceVactionBonus));
            }
        }

        public string TxtIncomeTaxVactionBonus
        {
            get { return $"{person.Incomes.Single(i => i.Type == Income.IncomeType.VacationBonus).IncomeTax.ToString()} €"; }
            set
            {
                person.Incomes.Single(i => i.Type == Income.IncomeType.VacationBonus).IncomeTax = decimal.Parse(value);
                this.RaisePropertyChangedEvent(nameof(TxtIncomeTaxVactionBonus));
            }
        }

        #endregion

        #endregion

        public string TxtGivenMonthlyIncome { get; set; } = "0";


        public string ButtonContent
        {
            get
            {
                return "Berechnen";
            }
        }


        public ICommand Calculate { get; set; }

        #region private methods

        private async Task GetCalculatedIncomes()
        {
            var income = decimal.Parse(this.TxtGivenMonthlyIncome);
            var values = new Dictionary<string, string>
            {
                { "alleinverdienerabsetzbetrag", "0" },
                { "arbeitsverhaeltnis","1" },
                { "brutto",$"Brutto:+{income}" },
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
                var responseText = await response.Content.ReadAsStringAsync();

                var doc = new HtmlDocument();
                doc.LoadHtml(responseText);

                FillupIncomesFor
                    ("laufender Bezug"
                    , s =>  this.TxtPreTaxMonthlyIncome = s
                    , s => this.TxtNationalInsuranceMonthlyIncome = s
                    , s => this.TxtIncomeTaxMonthlyIncome = s
                    , s => this.TxtAfterTaxMonthlyIncome = s);

                FillupIncomesFor
                    ("Urlaubszuschuss"
                    , s => this.TxtPreTaxIncomeVactionBonus = s
                    , s => this.TxtNationalInsuranceVactionBonus = s
                    , s => this.TxtIncomeTaxVactionBonus = s
                    , s => this.TxtAfterTaxMonthlyIncome = s
                    );

                FillupIncomesFor
                    ("Weihnachtsgeld"
                    , s => this.TxtPreTaxIncomeChristmasBonus = s
                    , s => this.TxtNationalInsuranceChristmasBonus = s
                    , s => this.TxtIncomeTaxChristmasBonus = s
                    , s => this.TxtAfterTaxChristmasBonus = s
                    );

                void FillupIncomesFor 
                    ( string searchString
                    , Action<string> preTaxIncome
                    , Action<string> nationalInsurance
                    , Action<string> incomeTax
                    , Action<string> afterTaxIncome
                    )
                {

                    var tables = doc.DocumentNode.Descendants("table").Where(node => node.HasClass("BnRechnerErgebnis320"));
                    foreach (var table in tables)
                    {
                        var rows = table.SelectNodes("tr");
                        if (rows?[0]?.InnerText.Contains(searchString) ?? false)
                        {
                            for (var i = 1; i < rows.Count; i++)
                            {
                                var str = rows[i].InnerText;
                                var matches = decimalNumberRegex.Matches(str);
                                if (matches.Count == 1)
                                {
                                    var decimalValue = decimal.Parse(matches[0].Value);
                                    if (str.Contains("Brutto"))
                                    {
                                        preTaxIncome(decimalValue.ToString());
                                    }
                                    else if (str.Contains("Sozialversicherung"))
                                    {
                                        nationalInsurance( decimalValue.ToString());
                                    }
                                    else if (str.Contains("Lohnsteuer"))
                                    {
                                        incomeTax(decimalValue.ToString());
                                    }
                                    else if (str.Contains("Netto"))
                                    {
                                        afterTaxIncome(decimalValue.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

    }
}

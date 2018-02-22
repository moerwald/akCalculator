using System;
using System.Collections.Generic;

namespace Calc.Model
{
    public class Person
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public DateTime BirthDate { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }

        public string Address  { get; set; }

        public List<Income> Incomes { get; set; } = new List<Income>
        {
            new Income { Type = Income.IncomeType.ChristmasBonus },
            new Income { Type = Income.IncomeType.MonthlyCredit },
            new Income { Type = Income.IncomeType.VacationBonus },
            new Income { Type = Income.IncomeType.YearlyIncome },
        };
    }

    public class Income
    {
        public enum IncomeType
        {
            Undef = 0,

            MonthlyCredit,

            YearlyIncome,

            ChristmasBonus,

            VacationBonus
        }


        public IncomeType Type { get; set; }

        public decimal PreTaxIncome { get; set; }

        public decimal NationalInsurance { get; set; }

        public decimal IncomeTax { get; set; }

        public decimal AfterTaxIncome { get; set; }
    }
}

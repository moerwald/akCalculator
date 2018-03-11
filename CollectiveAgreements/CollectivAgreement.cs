using System;
using System.Collections.Generic;

namespace CollectiveAgreements
{

    public class Row
    {
        public List<string> Cells { get; set; } = new List<string>();
    }

    public class Table
    {
        public List<string> TableHeader { get; set; } = new List<string>();

        public List<Row> Rows { get; set; } = new List<Row>();

    }

    public class CollectivAgreement
    {

        public CollectivAgreement()
        {
            this.MinimumIncomes = new Table();

            this.MinimumIncomes.TableHeader.Add("2018");
            this.MinimumIncomes.TableHeader.Add("ZT");
            this.MinimumIncomes.TableHeader.Add("AT");
            this.MinimumIncomes.TableHeader.Add("ST1");
            this.MinimumIncomes.TableHeader.Add("ST2");
            this.MinimumIncomes.TableHeader.Add("LT");

            var row = new Row();
            row.Cells.Add("Berufseinsteiger");
            row.Cells.Add("");
            row.Cells.Add("1767");
            row.Cells.Add("2273");
            row.Cells.Add("");
            row.Cells.Add("");
            this.MinimumIncomes.Rows.Add(row);


            row = new Row();
            row.Cells.Add("Eintstiegsstufe");
            row.Cells.Add("1507");
            row.Cells.Add("1860");
            row.Cells.Add("2393");
            row.Cells.Add("2984");
            row.Cells.Add("3925");
            this.MinimumIncomes.Rows.Add(row);

            row = new Row();
            row.Cells.Add("Regelstufe");
            row.Cells.Add("1783");
            row.Cells.Add("2.306");
            row.Cells.Add("2.898");
            row.Cells.Add("3.392");
            row.Cells.Add("4.487");
            this.MinimumIncomes.Rows.Add(row);
        }

        public string Name { get; set; }

        public Table MinimumIncomes { get; set; }

        public bool VactionIncome { get; set; }

        public bool ChristamsBonus { get; set; }


    }


    public class ItCollectiveAgreement : CollectivAgreement
    {
        public ItCollectiveAgreement()
        {
            this.MinimumIncomes = new Table();

            this.MinimumIncomes.TableHeader.Add("2018");
            this.MinimumIncomes.TableHeader.Add("ZT");
            this.MinimumIncomes.TableHeader.Add("AT");
            this.MinimumIncomes.TableHeader.Add("ST1");
            this.MinimumIncomes.TableHeader.Add("ST2");
            this.MinimumIncomes.TableHeader.Add("LT");

            var row = new Row();
            row.Cells.Add("Berufseinsteiger");
            row.Cells.Add("");
            row.Cells.Add("1767");
            row.Cells.Add("2273");
            row.Cells.Add("");
            row.Cells.Add("");
            this.MinimumIncomes.Rows.Add(row);

            row = new Row();
            row.Cells.Add("Eintstiegsstufe");
            row.Cells.Add("1507");
            row.Cells.Add("1860");
            row.Cells.Add("2393");
            row.Cells.Add("2984");
            row.Cells.Add("3925");
            this.MinimumIncomes.Rows.Add(row);

            row = new Row();
            row.Cells.Add("Regelstufe");
            row.Cells.Add("1783");
            row.Cells.Add("2.306");
            row.Cells.Add("2.898");
            row.Cells.Add("3.392");
            row.Cells.Add("4.487");
            this.MinimumIncomes.Rows.Add(row);


            this.VactionIncome = true;
            this.ChristamsBonus = true;

        }
    }

    public class TradingCollectiveAgreement : CollectivAgreement
    {
        public TradingCollectiveAgreement()
        {
            this.MinimumIncomes = new Table();

            this.MinimumIncomes.TableHeader.Add("Stufe (Jahr)");
            this.MinimumIncomes.TableHeader.Add("A");
            this.MinimumIncomes.TableHeader.Add("B");
            this.MinimumIncomes.TableHeader.Add("C");
            this.MinimumIncomes.TableHeader.Add("D");
            this.MinimumIncomes.TableHeader.Add("E");
            this.MinimumIncomes.TableHeader.Add("F");
            this.MinimumIncomes.TableHeader.Add("G");
            this.MinimumIncomes.TableHeader.Add("g");

            var row = new Row();

            row.Cells.Add("Stufe 1 (1. bis 3. Jahr)");
            row.Cells.Add("1.533,00");
            row.Cells.Add("1.585,00");
            row.Cells.Add("1.636,00");
            row.Cells.Add("1.738,00");
            row.Cells.Add("1.891,00");
            row.Cells.Add("2.147,00");
            row.Cells.Add("2.658,00");
            row.Cells.Add("3.271,00");
            this.MinimumIncomes.Rows.Add(row);

            row = new Row();

            row.Cells.Add("Stufe 2 (4. bis 6. Jahr)");
            row.Cells.Add("1.574,00");
            row.Cells.Add("1.636,00");
            row.Cells.Add("1.728,00");
            row.Cells.Add("1.866,00 ");
            row.Cells.Add("2.060,00");
            row.Cells.Add("2.402,00");
            row.Cells.Add("2.939,00");
            row.Cells.Add("3.577,00");

            this.MinimumIncomes.Rows.Add(row);

            row = new Row();

            row.Cells.Add("Stufe 3 (7. bis 9. Jahr)");
            row.Cells.Add("1.615,00");
            row.Cells.Add("1.687,00");
            row.Cells.Add("1.820,00");
            row.Cells.Add("1.993,00");
            row.Cells.Add("2.228,00");
            row.Cells.Add("2.658,00");
            row.Cells.Add("3.220,00");
            row.Cells.Add("3.884,00");
            this.MinimumIncomes.Rows.Add(row);


            row = new Row();
            row.Cells.Add("Stufe 4 (10. bis 12. Jahr)");
            row.Cells.Add("");
            row.Cells.Add("");
            row.Cells.Add("1.912,00");
            row.Cells.Add("2.121,00");
            row.Cells.Add("2.397,00");
            row.Cells.Add("2.913,00");
            row.Cells.Add("3.501,00");
            row.Cells.Add("4.191,00");
            this.MinimumIncomes.Rows.Add(row);


            row = new Row();
            row.Cells.Add("Stufe 5 (ab 13. Jahr");
            row.Cells.Add("");
            row.Cells.Add("");
            row.Cells.Add("2.004,00");
            row.Cells.Add("2.249,00");
            row.Cells.Add("2.566,00");
            row.Cells.Add("3.169,00");
            row.Cells.Add("3.782,00");
            row.Cells.Add("4.497,00");
            this.MinimumIncomes.Rows.Add(row);

            this.VactionIncome = true;
            this.ChristamsBonus = true;
        }
    }
}

using Funds.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funds
{
    public partial class frmMain : Form
    {
        FundsBindingList _ds = new FundsBindingList();
        public frmMain()
        {
            InitializeComponent();
            InitializeGrids();
        }

        private void InitializeGrids()
        {
            gridFunds.DataSource = _ds;
            gridFunds.Columns["MarketValue"].DefaultCellStyle.Format = "N2";
            gridFunds.Columns["TransactionCost"].DefaultCellStyle.Format = "N2";
            gridFunds.Columns["StockWeight"].DefaultCellStyle.Format = "P2";

            gridSummary.DataSource = _ds.SummaryBindingList;
            gridSummary.Columns["Type"].Width = 50;
            gridSummary.Columns["Quantity"].DefaultCellStyle.Format = "N0";
            gridSummary.Columns["Quantity"].Width = 50;
            gridSummary.Columns["MarketValue"].DefaultCellStyle.Format = "N2";
            gridSummary.Columns["MarketValue"].Width = 90;
            gridSummary.Columns["StockWeight"].DefaultCellStyle.Format = "P2";
            gridSummary.Columns["StockWeight"].Width = 50;
            gridSummary.DefaultCellStyle.SelectionBackColor = gridSummary.DefaultCellStyle.BackColor;
            gridSummary.DefaultCellStyle.SelectionForeColor = gridSummary.DefaultCellStyle.ForeColor;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _ds.Add(GetFinancialInstrument());
            }
        }

        private FinancialInstrument GetFinancialInstrument()
        {
            FinancialInstrument fi;
            if (rbBond.Checked)
            {
                fi = FinancialInstrument.Factory.Create<Bond>();
            }
            else 
            {
                fi = FinancialInstrument.Factory.Create<Equity>();
            }
            fi.Price = nrPrice.Value;
            fi.Quantity = Convert.ToInt32(nrQuantity.Value);
            return fi;
        }

        private void nrQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (nrQuantity.Value <= 0)
            {
                errorProvider.SetError(nrQuantity, "Quantity is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(nrQuantity, String.Empty);
            }
        }

        private void nrPrice_Validating(object sender, CancelEventArgs e)
        {
            if (nrPrice.Value <= 0)
            {
                errorProvider.SetError(nrPrice, "Price is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(nrPrice, String.Empty);
            }
        }

        private void gridFunds_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow rowAdded = gridFunds.Rows[e.RowIndex];
            FinancialInstrument fi = (FinancialInstrument)rowAdded.DataBoundItem;
            if(fi.TransactionCost > fi.TransactionCostTolerance || fi.MarketValue < 0)
            {
                rowAdded.DefaultCellStyle.BackColor = Color.Red;
            }
            
        }
    }
}

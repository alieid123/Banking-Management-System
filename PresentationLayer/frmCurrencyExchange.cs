using BusinessLayer_OfBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormForBank
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
            lblCurrentUser.Text = "Welecome, " + Program.CurrentUser.UserName;

            _LoadCurrenciesList(ref dv1);

        }

        DataView dv1;

       private void _LoadCurrenciesList(ref DataView dv1)
       {
           DataTable dataTable=clsCurrencies.GetAllCurrencies();
           dv1=new DataView(dataTable);
           dgvOfCurrenciesList.DataSource = dv1;
            _SetFormatofDGVOffCurrenciesList();
            lblNoOfAllClients.Text = $"{dataTable.Rows.Count} Currency(s) Found";
            _LoadCodeOfCurrencies(cobxCurrenciesCode);
            _LoadCodeOfCurrencies(cobxSourceCurrency);
            _LoadCodeOfCurrencies(cobxDestinationCurrency);            
       }

      private void _LoadCurrencyInfo(Label lbl,ComboBox combx,NumericUpDown num,Button btn)
      {
            clsCurrencies Currency=clsCurrencies.Find(combx.SelectedItem.ToString());
            lbl.Text = "Country: " + Currency.Country +
                                      "\nCode    : " + Currency.Code + 
                                      "\nName   : " + Currency.Name +
                                      "\nRate($): " + Currency.Rate_Per_1_Dolor;
                 num.Value= Convert.ToDecimal(Currency.Rate_Per_1_Dolor);   
            btn.Enabled = false;
      }

        private void _LoadCodeOfCurrencies(ComboBox combx)
        {
            combx.Items.Clear();
            foreach(DataRow row in dv1.Table.Rows)
            {
                combx.Items.Add(row["Code"]);
            }
        }

        private void _SetFormatofDGVOffCurrenciesList()
       {
           dgvOfCurrenciesList.Columns["ID"].Width = 60;
           dgvOfCurrenciesList.Columns["Country"].Width = 160;
           dgvOfCurrenciesList.Columns["Code"].Width = 110;
           dgvOfCurrenciesList.Columns["Name"].Width = 180;
           dgvOfCurrenciesList.Columns["Rate_Per_1_Dolor"].Width = 200;
        }       
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy\nhh:mm:ss tt");
        }

        private void dgvOfCurrenciesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            foreach (DataGridViewRow row in dgvOfCurrenciesList.Rows)
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.FromArgb(210, 230, 253) : Color.White;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dv1.RowFilter = $"Code LIKE '%{txtSearch.Text}%'";
        }

        private void cobxCurrenciesCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cobxCurrenciesCode.SelectedIndex != -1)
            {
                _LoadCurrencyInfo(lblCurrencyDetails,cobxCurrenciesCode,numUpdateCurrency,btnUpdateCurrency);
                   btnUpdateCurrency.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {    
            if (cobxCurrenciesCode.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure you want to update currency", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    clsCurrencies Currency = clsCurrencies.Find(cobxCurrenciesCode.SelectedItem.ToString());
                    Currency.Rate_Per_1_Dolor = Convert.ToSingle(numUpdateCurrency.Value);
                    Currency.Save();
                    _LoadCurrencyInfo(lblCurrencyDetails, cobxCurrenciesCode, numUpdateCurrency, btnUpdateCurrency);
                    _LoadCurrenciesList(ref dv1);
                }
            }
        }

        private void cobxSourceCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cobxSourceCurrency.SelectedIndex != -1)
            {
                _LoadCurrencyInfo(lblSourceCurrencyInfo, cobxSourceCurrency, numAmountToExchange, btnExchange);
                btnExchange.Enabled = true;
            }
        }

        private void cobxDestinationCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobxDestinationCurrency.SelectedIndex != -1)
            {
                _LoadCurrencyInfo(lblDestinationCurrencyInfo, cobxDestinationCurrency, numAmountToExchange, btnExchange);
                btnExchange.Enabled = true;
            }
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
           if(cobxSourceCurrency.SelectedIndex != -1&&cobxDestinationCurrency.SelectedIndex!=-1)
            {
                clsCurrencies SrcCurrent = clsCurrencies.Find(cobxSourceCurrency.SelectedItem.ToString());
                clsCurrencies DestCurrency=clsCurrencies.Find(cobxDestinationCurrency.SelectedItem.ToString());
                lblExchange.Text =Convert.ToString(numAmountToExchange.Value)+" "+ SrcCurrent.Code+"  ==  "+
                       Convert.ToString(clsCurrencies.ExchangeCurrencies(SrcCurrent.Code, DestCurrency.Code, Convert.ToSingle(numAmountToExchange.Value)))+" "+DestCurrency.Code;
            }
           else MessageBox.Show("Please Select Source&Destination Currency","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }
}

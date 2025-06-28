using BusinessLayer_OfBank;
using GeneralUtilities;
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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        clsClients SourceClient;
        clsClients DestinationClient;
        DataView dv1;
        DataView dv2;
        DataView dv3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy\nhh:mm:ss tt");
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
         lblCurrentUser.Text = $"Welcome, {Program.CurrentUser.UserName}";
            _LoadAccNumbersInCombobox(cobxWithDraw);
            _LoadAccNumbersInCombobox(cobDepositAccNumbers);
            clsHelper.SetControlsState(false,numDepositAmount,btnDeposit,numWithdraw,btnWithdraw);
            clsHelper.SetVisibility(false,lblBalance,lblCurrentBalance,lablBalance1,lblCurrentBalanceAfterWithDraw);
            _LoadTotalBalances();
            _LoadClinetsShortedList(ref dv1);
            _transferBalance();
            _LoadTransactionsLog(ref dv2);
            _LoadTransferLog(ref dv3);  
        }       

        private void _transferBalance()
        {
            clsHelper.SetControlsState(false, numTransfer, btnTransfer, cobxDestinationAccNumber);
           _LoadAccNumbersInCombobox(cobxSourceAcc);            
        }

        private void _setFormatofDGVOfTranfsferLog()
        {
           dgvTransferLog.Columns["ID"].Width = 40;
           dgvTransferLog.Columns["SourceAccNo"].Width = 120;
           dgvTransferLog.Columns["DestinationAccNo"].Width = 160;
           dgvTransferLog.Columns["SourceBalance"].Width = 140;
           dgvTransferLog.Columns["DestinationBalance"].Width = 180;
           dgvTransferLog.Columns["UserName"].Width = 100;
           dgvTransferLog.Columns["Amount"].Width = 100;
           dgvTransferLog.Columns["DateTime"].Width = 180;
        }

        private void _LoadTransferLog(ref DataView dv)
        {
            DataTable dt = clsTransfer.GetAllTrnafer();
            dv=new DataView(dt);
            dgvTransferLog.DataSource = dv;
            _setFormatofDGVOfTranfsferLog();
        }
        private void _LoadTransactionsLog(ref DataView dv)
        {
            DataTable dt=clsTransactions.GetAllTransactions();
             dv = new DataView(dt);
            dgvTransactionLog.DataSource = dv;
            SetForamtOfDGVOfTransLog();
        }

        private void _LoadClinetsShortedList( ref DataView dv)
        {
         
            DataTable ClientsDataTable = clsClients.GetAllClients();
          DataView  dataview = new DataView(ClientsDataTable);
            
           DataTable  selectedColumns = dataview.ToTable(false, "AccountNumber", "FirstName", "LastName", "Balance");
             dv = new DataView(selectedColumns);

            dgvBalances.DataSource = dv;
            SetForamtOfDGVOfBalances();
        }
        private void _LoadTotalBalances()
        {            
           DataTable dt=clsClients.GetAllClients();
            lblTotalBalances.Text = Convert.ToString(clsTransactions.GetAllBalances()) + "$";
            lblTotalBalancesInString.Text = clsString.NumberToText(Convert.ToInt32(clsTransactions.GetAllBalances()));
        }

        private void  _LoadAccNumbersInCombobox(ComboBox combx,bool IsDestnation=false)
        {
            combx.Items.Clear();
            DataTable datetable=clsClients.GetAllClients();
            if(!IsDestnation)
            {
                foreach (DataRow Row in datetable.Rows)
                {
                    combx.Items.Add(Row["AccountNumber"]);
                }
            }           
            else
            {
                foreach (DataRow Row in datetable.Rows)
                {
                    if (cobxSourceAcc.Text!= Row["AccountNumber"].ToString())
                    combx.Items.Add(Row["AccountNumber"]);
                }
            }
        }
        private void btnDeposit_MouseHover(object sender, EventArgs e)
        {
            btnDeposit.FlatAppearance.BorderSize = 1;
        }

        private void btnDeposit_MouseLeave(object sender, EventArgs e)
        {
            btnDeposit.FlatAppearance.BorderSize = 0;
        }

        private void cobAccNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobDepositAccNumbers.Text != "")
            {
                SourceClient = clsClients.Find(cobDepositAccNumbers.Text);
                clsHelper.SetControlsState(true, numDepositAmount, btnDeposit);
                lblCurrentBalance.Text = SourceClient.Balance.ToString() + "$";
                clsHelper.SetVisibility(true, lblBalance, lblCurrentBalance);
            }
            else
                lblCurrentBalance.Text = "";
        }

        private void _RefreshDGVS()
        {
            _LoadTotalBalances();
            _LoadClinetsShortedList(ref dv1);
            _transferBalance();
            _LoadTransactionsLog(ref dv2);
            _LoadTransferLog(ref dv3);
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to deposit  {numDepositAmount.Value}$ ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
              if (clsTransactions.Depsite(cobDepositAccNumbers.SelectedItem.ToString(), numDepositAmount.Value))
              {
                    MessageBox.Show($"Amount {numDepositAmount.Value} Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCurrentBalance.Text = SourceClient.Balance.ToString() + "$";
                    clsHelper.SetControlsState(false, numDepositAmount, btnDeposit);
                    clsHelper.SetVisibility(false, lblBalance, lblCurrentBalance);
                    cobDepositAccNumbers.Text = "";
                    numDepositAmount.Value = 10;
                    _RefreshDGVS();                   
              }
              
            }
        }
        private void btnWithdraw_MouseHover(object sender, EventArgs e)
        {
            btnWithdraw.FlatAppearance.BorderSize = 1;
        }

        private void btnWithdraw_MouseLeave(object sender, EventArgs e)
        {
            btnWithdraw.FlatAppearance.BorderSize = 0;
        }

        private void cobxWithDraw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobxWithDraw.Text != "")
            {
                SourceClient = clsClients.Find(cobxWithDraw.Text);
                clsHelper.SetControlsState(true, numWithdraw, btnWithdraw);
                lblCurrentBalanceAfterWithDraw.Text = SourceClient.Balance.ToString() + "$";
                clsHelper.SetVisibility(true, lablBalance1, lblCurrentBalanceAfterWithDraw);                
            }
            else 
            lblCurrentBalanceAfterWithDraw.Text = "";
        }

        private void numWithdraw_ValueChanged(object sender, EventArgs e)
        {
            if(numWithdraw.Value >SourceClient.Balance)
            {
                numWithdraw.Value = SourceClient.Balance;
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(numWithdraw.Value>SourceClient.Balance)            
                MessageBox.Show("You do not have enough balance to complete this transaction","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(MessageBox.Show($"Are you sure you want to withdraw {numWithdraw.Value}$ ","Confirm",MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                   if(clsTransactions.WithDraw(cobxWithDraw.SelectedItem.ToString(), numWithdraw.Value))
                    {
                        MessageBox.Show($"Amount {numWithdraw.Value}$ withdraw Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblCurrentBalanceAfterWithDraw.Text = SourceClient.Balance.ToString() + "$";
                        clsHelper.SetControlsState(false, numWithdraw, btnWithdraw);
                        clsHelper.SetVisibility(false, lablBalance1, lblCurrentBalanceAfterWithDraw);
                        cobxWithDraw.Text = "";
                        numWithdraw.Value = 10;
                        _RefreshDGVS();
                    }

                }
            }
            
        }

        private void tabTotalBalances_MouseClick(object sender, MouseEventArgs e)
        {
            _LoadTotalBalances();
        }
        private void dgvBalances_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvBalances.Rows)
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.FromArgb(210, 230, 253) : Color.White;
        }

        private void SetForamtOfDGVOfBalances()
        {
            dgvBalances.Columns["AccountNumber"].Width = 170;
            dgvBalances.Columns["FirstName"].Width = 130;
            dgvBalances.Columns["LastName"].Width = 130;
            dgvBalances.Columns["Balance"].Width = 130;
        }

        private void SetForamtOfDGVOfTransLog()
        {
            dgvTransactionLog.Columns["ID"].Width = 40;
            dgvTransactionLog.Columns["AccountNumber"].Width = 145;
            dgvTransactionLog.Columns["DateTime"].Width = 180;
            dgvTransactionLog.Columns["Amount"].Width = 120;
            dgvTransactionLog.Columns["Transaction_Name"].Width = 180;
        }
     
  
        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            dv1.RowFilter = $"AccountNumber LIKE '%{txtbSearch.Text}%'";            
        }
        private void cobxSourceAcc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cobxSourceAcc.Text!="")
            {
                 SourceClient = clsClients.Find(cobxSourceAcc.Text);
                lblSrcBalance.Text = SourceClient.Balance.ToString() + "$";
                _LoadAccNumbersInCombobox(cobxDestinationAccNumber, true);
                cobxDestinationAccNumber.Enabled = true;                  
            }
        }

        private void cobxDestinationAccNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobxDestinationAccNumber.SelectedIndex != -1)
            {
                 DestinationClient = clsClients.Find(cobxDestinationAccNumber.SelectedItem.ToString());
                lblDesBalance.Text = DestinationClient.Balance.ToString() + "$";
                clsHelper.SetControlsState(true, numTransfer, btnTransfer, cobxDestinationAccNumber);

            }
        }

        private void numTransfer_ValueChanged(object sender, EventArgs e)
        {
           if(numTransfer.Value>SourceClient.Balance&& SourceClient.Balance!=0)
           {
                numTransfer.Value=SourceClient.Balance;
           }
        }

        private void _ClearTrnaferform()
        {
            cobxSourceAcc.SelectedIndex = cobxDestinationAccNumber.SelectedIndex = -1;         
            lblSrcBalance.Text = lblDesBalance.Text = "";
            numTransfer.Value = 10;
            btnTransfer.Enabled = false;
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {

            if (cobxSourceAcc.Text == cobxDestinationAccNumber.Text)
            {
                MessageBox.Show("Please Select Different Account Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                    
            }

            if (numTransfer.Value > SourceClient.Balance)
                MessageBox.Show("You do not have enough balance to complete this transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show($"Are you sure you want to Transfer {numTransfer.Value}$ From {SourceClient.AccountNumber} to {DestinationClient.AccountNumber} ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    clsTransfer.AddNewTransfer(cobxSourceAcc.Text, cobxDestinationAccNumber.Text, Program.CurrentUser.UserName, numTransfer.Value, DateTime.Now);
                    MessageBox.Show($"Amount {numTransfer.Value}$ Transfered Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   _ClearTrnaferform();
                    _RefreshDGVS();
                }
            }
        }

        private void dgvTransactionLog_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTransactionLog.Rows)
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.FromArgb(210, 230, 253) : Color.White;
        }
        private void txtbTranscionLog_TextChanged(object sender, EventArgs e)
        {
            dv2.RowFilter = $"AccountNumber LIKE '%{txtbTranscionLog.Text}%'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dv3.RowFilter = $"DestinationAccNo LIKE '%{txtbSearchTransferLog.Text}%'";

        }

        private void dgvTransferLog_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTransferLog.Rows)
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.FromArgb(210, 230, 253) : Color.White;

        }
  
    }
}

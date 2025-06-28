using BusinessLayer_OfBank;
using GeneralUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormForBank
{
    public partial class frmClients : Form
    {
        enum enMode { AddNew = 0, Update = 1, Find = 2 };
        enMode Mode;
        DataView ClientsDataView;

        public frmClients()
        {
            InitializeComponent();
            clsHelper.SetBorderSize(btnListClients, btnAddNewClient, btnUpdateClient, btnFindClient,btnSave,btnSearch);
        }
        private void frmClients_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = $"Welcome, {Program.CurrentUser.UserName}";
            _LoadClientsList( ref ClientsDataView);
            HideTabs();
        }
        private void HideTabs()
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy\nhh:mm:ss tt");
        }
        private void _LoadClientsList(ref DataView dataview)
        {
            DataTable ClientsDataTable = clsClients.GetAllClients();
            dataview = new DataView(ClientsDataTable);
            dgvListClients.DataSource = dataview;
            lblNoOfAllClients.Text = $"{ClientsDataTable.Rows.Count} Client(s) Found";
            dgvListClients.Columns["Email"].Width = 200;
            dgvListClients.Columns["AccountNumber"].Width = 140;
            dgvListClients.Columns["PinCode"].Width = 80;
            dgvListClients.Columns["Phone"].Width = 150;
            dgvListClients.Columns["ID"].Width = 50;


        }
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Mode = enMode.AddNew;
            PrepareClientForm("Add New Client", false, true);
            btnSave.Visible = true;
        }
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Mode = enMode.Update;
            PrepareClientForm("Update Client", true, false);
            btnSave.Visible = true;
        }
        private void btnFindClient_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Mode = enMode.Find;
            PrepareClientForm("Find Client", true, false);
            btnSave.Visible = false;
        }
        private void PrepareClientForm(string title, bool showSearch, bool enableInputs)
        {
            lblAddUpdateFindClient.Text = title;
            clsHelper.SetVisibility(showSearch, lblSearch, txtbSearchClient, pictureBox3, btnSearch);
            clsHelper.ClearTextBoxes(txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbPinCode, txtbAccNo, txtbBalance, txtbSearchClient);
            if (enableInputs)
                clsHelper.SetTextBoxState(true, txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbPinCode, txtbAccNo, txtbBalance);
            else
                DisableTextInputs();
        }
        private void DisableTextInputs()
        {
            clsHelper.SetTextBoxState(false, txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbPinCode, txtbAccNo, txtbBalance);
        }
        private void dgvListClients_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvListClients.Rows)
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.FromArgb(210, 230, 253) : Color.White;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ClientsDataView.RowFilter = $"AccountNumber LIKE '%{txtSearch.Text}%'";
        }
        private void txtbEmail_Validating(object sender, CancelEventArgs e)
        {
            clsHelper.ValidateEmail(txtbEmail, errorProvider1, e);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (clsHelper.AreAnyTextBoxesEmpty(txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbAccNo, txtbPinCode, txtbBalance))
            {
                MessageBox.Show("Please Complete All Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Mode == enMode.AddNew)
            {
                if (clsClients.IsExist(txtbAccNo.Text))
                {
                    MessageBox.Show("Account Number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newClient = CreateClientFromForm();
                if (newClient.Save())
                    MessageBox.Show($"Client [AccNo:{newClient.AccountNumber}] has been added successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("The addition process failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Mode == enMode.Update)
            {
                if (!clsClients.IsExist(txtbAccNo.Text))
                {
                    MessageBox.Show("Client NOT Found");
                    return;
                }

                var updateClient = clsClients.Find(txtbAccNo.Text);
                FillClientFromForm(updateClient);
                updateClient.Save();
                MessageBox.Show($"Client [AccNo:{updateClient.AccountNumber}] has been Updated successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableTextInputs();
            }

            _LoadClientsList(ref ClientsDataView);
            clsHelper.ClearTextBoxes(txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbPinCode, txtbAccNo, txtbBalance, txtbSearchClient);
        }
        private clsClients CreateClientFromForm()
        {
            return new clsClients
            {
                FirstName = txtbFirstName.Text,
                LastName = txtbLastName.Text,
                Email = txtbEmail.Text,
                Phone = txtbPhone.Text,
                PinCode = txtbPinCode.Text,
                AccountNumber = txtbAccNo.Text,
                Balance = decimal.Parse(txtbBalance.Text)
            };
        }
        private void FillClientFromForm(clsClients client)
        {
            client.FirstName = txtbFirstName.Text;
            client.LastName = txtbLastName.Text;
            client.Email = txtbEmail.Text;
            client.Phone = txtbPhone.Text;
            client.PinCode = txtbPinCode.Text;
            client.Balance = decimal.Parse(txtbBalance.Text);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbSearchClient.Text))
            {
                MessageBox.Show("Please Enter Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var client = clsClients.Find(txtbSearchClient.Text);
            if (client != null)
            {
                txtbFirstName.Text = client.FirstName;
                txtbLastName.Text = client.LastName;
                txtbEmail.Text = client.Email;
                txtbPhone.Text = client.Phone;
                txtbPinCode.Text = client.PinCode;
                txtbBalance.Text = client.Balance.ToString();
                txtbAccNo.Text = client.AccountNumber;

                if (Mode == enMode.Update)
                {
                    clsHelper.SetTextBoxState(true, txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbPinCode, txtbAccNo, txtbBalance);

                }
            }
            else
            {
                MessageBox.Show($"Client [{txtbSearchClient.Text}] NOT Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdateClient.PerformClick();
            txtbSearchClient.Text = dgvListClients.CurrentRow.Cells[5].Value.ToString();
            btnSearch.PerformClick();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string accNo = dgvListClients.CurrentRow.Cells[5].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete the client [{accNo}]?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsClients.DeleteClient(accNo))
                {
                    MessageBox.Show("Client Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadClientsList(ref ClientsDataView);
                }
                else
                {
                    MessageBox.Show("The client deletion process failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsHelper.InputLettersOnly(sender, e);
        }
        private void txtbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsHelper.InputLettersOnly(sender, e);
        }
        private void txtbPinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsHelper.InputNumbersOnly(sender, e);
        }
        private void txtbBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsHelper.Decimalnumbers(sender, e);
        }
        private void txtbAccNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsHelper.InputNumbersOnly(sender, e);
        }
        private void txtbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsHelper.InputNumbersOnly(sender, e);
        }
        private void btnListClients_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }  
        private void txtbSearchClient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbSearchClient.Text))
                PrepareClientForm("Update Client", true, false);                                           
        }
      
    }
}
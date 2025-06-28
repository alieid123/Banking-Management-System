using System;
using System.Collections.Generic;
using GeneralUtilities;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer_OfBank;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormForBank
{
    public partial class frmUsers : Form
    {

        enum enMode { AddNew = 0, Update = 1, Find = 2 };
        enMode Mode;
        DataView  UsersDataView;
           
        public frmUsers()
        {
            InitializeComponent();
            clsHelper.SetBorderSize(btnListUsers, btnAddNewUser, btnUpdateUser, btnFindUser, btnSave, btnSearch);
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = $"Welcome, {Program.CurrentUser.UserName}";
            _LoadUsersList(ref UsersDataView);
            HideTabs();
        }     
        private void HideTabs()
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        private void _LoadUsersList(ref DataView dataview)
        {
            DataTable UsersDataTable = clsUsers.GetAllUsers();
            dataview = new DataView(UsersDataTable);
            dgvListUsers.DataSource = dataview;
            lblNoOfAllUsers.Text = $"{UsersDataTable.Rows.Count} User(s) Found";

            dgvListUsers.Columns["Email"].Width = 200;
            dgvListUsers.Columns["Phone"].Width = 130;
            dgvListUsers.Columns["ID"].Width = 50;


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy\nhh:mm:ss tt");
        }
        private void PrepareUserForm(string title, bool showSearch, bool enableInputs)
        {
            lblAddUpdateFindUser.Text = title;
            clsHelper.SetVisibility(showSearch,lblUserName, lblPassword, txtbSearchByUser,txtSearchByPassword, btnSearch);
            clsHelper.ClearTextBoxes(txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbUserName,txtbPassword,txtbSearchByUser,txtSearchByPassword);
            clsHelper.ClearGroupBoxSelections(grpbPermissions);

            if (enableInputs)
            {                
                clsHelper.SetTextBoxState(true, txtbFirstName, txtbLastName, txtbEmail, txtbPhone,txtbUserName,txtbPassword);
                clsHelper.SetControlsState(true,grpbPermissions);
            }
            else
                DisableTextInputs();
        }
        private void DisableTextInputs()
        {
            clsHelper.SetTextBoxState(false, txtbFirstName, txtbLastName, txtbEmail, txtbPhone,txtbUserName, txtbPassword);
            clsHelper.SetControlsState(false, grpbPermissions);
        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Mode = enMode.AddNew;
            PrepareUserForm("Add New User", false, true);
            btnSave.Visible = true;
        }  
        private void dgvListUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvListUsers.Rows)
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.FromArgb(210, 230, 253) : Color.White;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UsersDataView.RowFilter = $"UserName LIKE '%{txtSearch.Text}%'";
        }
        private void txtbEmail_Validating(object sender, CancelEventArgs e)
        {
            clsHelper.ValidateEmail(txtbEmail, errorProvider1, e);
        }
        private clsUsers CreateUserFromForm()
        {
            clsUsers user = new clsUsers();
            user.FirstName = txtbFirstName.Text;
            user.LastName = txtbLastName.Text;
            user.Email = txtbEmail.Text;
            user.Phone = txtbPhone.Text;
            user.UserName = txtbUserName.Text;
            user.Password = txtbPassword.Text;
            if (rdnYes.Checked) user.Permissions = -1;
            else
            {
                foreach (Control control in grpbPermissions.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox chkb && chkb.Checked == true)
                    {
                        user.Permissions += Convert.ToInt16(chkb.Tag.ToString());
                    }
                }
            }
            return user;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsHelper.AreAnyTextBoxesEmpty(txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbUserName)&&rdnYes.Checked==false&&rdbNo.Checked==false&&chkbManageClients.Checked==false&&chkbManageUsers.Checked==false&&chkbManageTransactions.Checked==false&&chkbCurrencyExchange.Checked==false)
            {
                MessageBox.Show("Please Complete All Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Mode == enMode.AddNew)
            {
                if (clsUsers.IsExist(txtbUserName.Text))
                {
                    MessageBox.Show("UserName already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newUser = CreateUserFromForm();
                if (newUser.Save())
                    MessageBox.Show($"User [UserName:{newUser.UserName}] has been added successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("The addition process failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Mode == enMode.Update)
            {
                if (!clsUsers.IsExist(txtbUserName.Text))
                {
                    MessageBox.Show("User NOT Found");
                    return;
                }

                var updateUser = clsUsers.Find(txtbUserName.Text,txtbPassword.Text);
                FillUserFromForm(updateUser);
                updateUser.Save();
                MessageBox.Show($"User [UserName: {updateUser.UserName}] has been Updated successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableTextInputs();
            }


            _LoadUsersList(ref UsersDataView);
            clsHelper.ClearTextBoxes(txtbFirstName, txtbLastName,txtbUserName, txtbEmail, txtbPhone,txtbPassword,txtbSearchByUser,txtSearchByPassword);
            clsHelper.ClearGroupBoxSelections(grpbPermissions);
        }
        private void FillUserFromForm(clsUsers user)
        {
            user.UserName = txtbUserName.Text;
            user.FirstName = txtbFirstName.Text;
            user.LastName = txtbLastName.Text;
            user.Email = txtbEmail.Text;
            user.Phone = txtbPhone.Text;
            user.Password = txtbPassword.Text;
            if (rdnYes.Checked) user.Permissions = -1;
            else
            {
                user.Permissions = 0; 
                foreach (Control control in grpbPermissions.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox chkb && chkb.Checked == true)
                    {
                        user.Permissions += Convert.ToInt16(chkb.Tag.ToString());
                    }
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtbSearchByUser.Text)||string.IsNullOrEmpty(txtSearchByPassword.Text))
            {
                MessageBox.Show("Please Enter UserName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = clsUsers.Find(txtbSearchByUser.Text, txtSearchByPassword.Text);
            if (user != null)
            {
                txtbFirstName.Text = user.FirstName;
                txtbLastName.Text = user.LastName;
                txtbEmail.Text = user.Email;
                txtbPhone.Text = user.Phone;
                txtbPassword.Text = user.Password;
                txtbUserName.Text = user.UserName;

                foreach (Control Ctr in grpbPermissions.Controls)
                {
                    if (Ctr is System.Windows.Forms.CheckBox Chkb)
                    {
                        int permissionValue = Convert.ToInt16(Chkb.Tag);
                        Chkb.Checked = (permissionValue & user.Permissions) == permissionValue;
                    }
                }
                if (Mode == enMode.Update)
                {
                    clsHelper.SetTextBoxState(true, txtbFirstName, txtbLastName, txtbEmail, txtbPhone, txtbPassword,txtbUserName);
                    clsHelper.SetControlsState(true, grpbPermissions);
                   
                }
            }
            else
            {
                MessageBox.Show($"User [{txtbSearchByUser.Text}] NOT Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdateUser.PerformClick();
            txtbSearchByUser.Text = dgvListUsers.CurrentRow.Cells[1].Value.ToString();
            txtSearchByPassword.Text = dgvListUsers.CurrentRow.Cells[6].Value.ToString();
            btnSearch.PerformClick();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string username = dgvListUsers.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete the user [{username}]?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsUsers.DeleteUser(username))
                {
                    MessageBox.Show("user Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadUsersList(ref UsersDataView);
                }
                else
                {
                    MessageBox.Show("The User deletion process failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsHelper.InputNumbersOnly(sender, e);
        }
        private void btnListUsers_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Mode = enMode.Update;
            PrepareUserForm("Update User", true, false);
            btnSave.Visible = true;
        }
        private void btnFindUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Mode = enMode.Find;
            PrepareUserForm("Find User", true, false);
            btnSave.Visible = false;
        }
        private void rdnYes_CheckedChanged(object sender, EventArgs e)
        {
            if(rdnYes.Checked)
            {
                foreach(Control c in grpbPermissions.Controls)
                {
                    if(c is System.Windows.Forms.CheckBox Chkb)
                    {
                        Chkb.Checked = true;
                        Chkb.Enabled = false;
                    }
                }
            }
        }
        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNo.Checked)
            {
                foreach (Control c in grpbPermissions.Controls)
                {
                    if (c is System.Windows.Forms.CheckBox Chkb)
                    {
                        Chkb.Checked = false;
                        Chkb.Enabled = true;
                    }
                }
            }
        }

        private void tabListUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

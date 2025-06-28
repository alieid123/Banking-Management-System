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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Visible = false;
            this.AcceptButton = btnLogin;    
            btnHide.Visible= false;
            btnShow.Visible=false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }      
           
        private void txtbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbUserName.Text)|| txtbUserName.Text=="Enter Username")
            {
                e.Cancel = true;
                txtbUserName.Focus();
                errorProvider1.SetError(txtbUserName, "UserName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtbUserName, "");
            }

        }

        byte Trails = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            Trails--;
            if (Trails <= 0)
            {
                btnLogin.Visible = false;
                txtbUserName.Enabled = false;
                mtxtbPassword.Enabled = false;
                lblInvalidInput.Text = "Your Account Locked Please,\nContact With Bank";
                return;
                           
            }

            Program.CurrentUser = clsUsers.Find(txtbUserName.Text.ToString(), mtxtbPassword.Text.ToString());
                if (Program.CurrentUser != null)
                {    clsLoginRegisters.AddNewLoginRegiste(Program.CurrentUser.UserName, Program.CurrentUser.Password, Program.CurrentUser.Permissions, DateTime.Now);
                   Form frm =new frmHome();
                frm.ShowDialog();
                    mtxtbPassword.Clear();
                    txtbUserName.Clear();
                    lblInvalidInput.Text = "";
                    Trails = 3;
                }
                else               
                    lblInvalidInput.Text=$"Invalid UserName Or Password!!\n you have {Trails} attempts before lock account";                                               
        }

        private void txtbUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtbUserName.Text != "" && txtbUserName.Text != "Enter Username" && mtxtbPassword.Text != "" && mtxtbPassword.Text != "Enter Password") btnLogin.Visible = true;
            else btnLogin.Visible = false;
        }

        private void txtbUserName_Enter(object sender, EventArgs e)
        {
            if(txtbUserName.Text=="Enter Username")
            {
                txtbUserName.Text = "";
                txtbUserName.ForeColor = Color.FromArgb(0, 117, 214);

            }
        }
                     
        private void mtxtbPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtbUserName.Text != "" && txtbUserName.Text != "Enter Username" && mtxtbPassword.Text != "" && mtxtbPassword.Text != "Enter Password") btnLogin.Visible = true;
            else btnLogin.Visible = false;
        }

        private void mtxtbPassword_Enter_1(object sender, EventArgs e)
        {
            if (mtxtbPassword.Text == "Enter Password")
            {
                mtxtbPassword.UseSystemPasswordChar = true;
                mtxtbPassword.Text = "";
                mtxtbPassword.ForeColor = Color.FromArgb(0, 117, 214);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            mtxtbPassword.UseSystemPasswordChar = false;
            btnShow.Visible = false;
            btnHide.Visible = true;

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            mtxtbPassword.UseSystemPasswordChar = true;
            btnHide.Visible = false;
            btnShow.Visible=true;

        }

        private void mtxtbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtbPassword.Text) || mtxtbPassword.Text == "Enter Password")
            {
                e.Cancel = true;
                mtxtbPassword.Focus();
                errorProvider1.SetError(mtxtbPassword, "Password should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtbPassword, "");
            }
        }

        private void mtxtbPassword_TextChanged_1(object sender, EventArgs e)
        {
            if (txtbUserName.Text != "" && txtbUserName.Text != "Enter Username" && mtxtbPassword.Text != "" && mtxtbPassword.Text != "Enter Password")
            {
                btnLogin.Visible = true;
                btnShow.Visible=true;
            }
            else btnLogin.Visible = false;
        }
    }
}

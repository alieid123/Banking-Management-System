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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();   
            
        }
        private void ArrangeButtonsInOriginalOrder(params Button[] buttons)
        {
            int y = buttons[0].Location.Y; 

            foreach (Button btn in buttons)
            {
                if (btn.Visible)
                {
                    btn.Location = new Point(btn.Location.X, y);
                    y += btn.Height + 22;
                }
            }
        }
        private void CheckPermissions()
        {
            if(Program.CurrentUser.Permissions==-1|| Program.CurrentUser.Permissions==15)
            {
                clsHelper.SetVisibility(true, btnClients, btnTransactions, btnUsers, btnExchange,btnRegiters);
                return;
            }
            short Per = Convert.ToInt16(btnClients.Tag.ToString());
            if ((Per & Program.CurrentUser.Permissions) != Per)
            {
                btnClients.Visible = false;
                ArrangeButtonsInOriginalOrder(btnClients,btnTransactions,btnExchange,btnUsers,btnRegiters);

            }

            Per = Convert.ToInt16(btnTransactions.Tag.ToString());
            if ((Per & Program.CurrentUser.Permissions) != Per)
            {                               
                btnTransactions.Visible = false;
                ArrangeButtonsInOriginalOrder(btnClients, btnTransactions, btnExchange, btnUsers, btnRegiters);
            }

            Per = Convert.ToInt16(btnUsers.Tag.ToString());
            if ((Per & Program.CurrentUser.Permissions) != Per)
            {                             
                btnUsers.Visible = false;
                ArrangeButtonsInOriginalOrder(btnClients, btnTransactions, btnExchange, btnUsers, btnRegiters);
            }

            Per = Convert.ToInt16(btnExchange.Tag.ToString());
            if ((Per & Program.CurrentUser.Permissions) != Per)
            {               
                btnExchange.Visible = false;
                ArrangeButtonsInOriginalOrder(btnClients, btnTransactions, btnExchange, btnUsers, btnRegiters);
            }
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = $"Welcome, {Program.CurrentUser.UserName}";
            clsHelper.SetVisibility(true, btnClients, btnTransactions, btnUsers, btnExchange);
            CheckPermissions();
        }
        protected void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\n" + DateTime.Now.ToString("hh:mm:ss tt");         
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnClients.FlatAppearance.BorderSize = 1;
        }
        private void btnClients_MouseLeave(object sender, EventArgs e)
        {
            btnClients.FlatAppearance.BorderSize = 0;
        }
        private void btnUsers_MouseHover(object sender, EventArgs e)
        {
            btnUsers.FlatAppearance.BorderSize = 1;
        }
        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnUsers.FlatAppearance.BorderSize = 0;

        }
        private void btnTransactions_MouseHover(object sender, EventArgs e)
        {
            btnTransactions.FlatAppearance.BorderSize = 1;
        }
        private void btnTransactions_MouseLeave(object sender, EventArgs e)
        {
            btnTransactions.FlatAppearance.BorderSize = 0;
        }
        private void btnExchange_MouseHover(object sender, EventArgs e)
        {
            btnExchange.FlatAppearance.BorderSize = 1;
        }
        private void btnExchange_MouseLeave(object sender, EventArgs e)
        {
            btnExchange.FlatAppearance.BorderSize = 0;
        }
        private void btnRegiters_MouseHover(object sender, EventArgs e)
        {
            btnRegiters.FlatAppearance.BorderSize = 1;
        }
        private void btnRegiters_MouseLeave(object sender, EventArgs e)
        {
            btnRegiters.FlatAppearance.BorderSize = 0;
        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            btnLogout.FlatAppearance.BorderSize = 1;
        }
        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.FlatAppearance.BorderSize = 0;
        }
        private void btnClients_Click(object sender, EventArgs e)
        {
           Form frm=new frmClients();
            frm.ShowDialog();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form frm=new frmUsers();
            frm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Form frm= new frmTransactions();
            frm.ShowDialog();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            Form frm =new frmCurrencyExchange();
            frm.ShowDialog();

        }

        private void btnRegiters_Click(object sender, EventArgs e)
        {
            Form frm=new frmLoginRegisters();
            frm.ShowDialog();
        }
    }
}

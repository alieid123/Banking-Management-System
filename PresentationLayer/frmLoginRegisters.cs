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
    public partial class frmLoginRegisters : Form
    {
        public frmLoginRegisters()
        {
            InitializeComponent();
        }

        DataView dv1;

        private void _LoadLoginRegisters(ref DataView dv)
        {
            DataTable dt = clsLoginRegisters.GetAllRegisters();
            dv=new DataView(dt);
            dgvLoginRegisters.DataSource=dv;
            dgvLoginRegisters.Columns["DateTime"].Width = 250;
        }

        private void frmLoginRegisters_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = $"Welcome, {Program.CurrentUser.UserName}";
            _LoadLoginRegisters(ref dv1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy\nhh:mm:ss tt");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dv1.RowFilter = $"UserName LIKE '%{txtSearch.Text}%'";
        }

        private void dgvLoginRegisters_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLoginRegisters.Rows)
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.FromArgb(210, 230, 253) : Color.White;
        }
    }
}

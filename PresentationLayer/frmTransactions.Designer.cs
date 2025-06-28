namespace WinFormForBank
{
    partial class frmTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.numDepositAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobDepositAccNumbers = new System.Windows.Forms.ComboBox();
            this.tabWithdraw = new System.Windows.Forms.TabPage();
            this.lblCurrentBalanceAfterWithDraw = new System.Windows.Forms.Label();
            this.lablBalance1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.numWithdraw = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cobxWithDraw = new System.Windows.Forms.ComboBox();
            this.tabTotalBalances = new System.Windows.Forms.TabPage();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBalances = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBalancesInString = new System.Windows.Forms.Label();
            this.lblTotalBalances = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTransferBalances = new System.Windows.Forms.TabPage();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numTransfer = new System.Windows.Forms.NumericUpDown();
            this.lblDesBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSrcBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cobxDestinationAccNumber = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cobxSourceAcc = new System.Windows.Forms.ComboBox();
            this.tabTransactionLog = new System.Windows.Forms.TabPage();
            this.txtbTranscionLog = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvTransactionLog = new System.Windows.Forms.DataGridView();
            this.tabTransferLog = new System.Windows.Forms.TabPage();
            this.dgvTransferLog = new System.Windows.Forms.DataGridView();
            this.txtbSearchTransferLog = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositAmount)).BeginInit();
            this.tabWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdraw)).BeginInit();
            this.tabTotalBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabTransferBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransfer)).BeginInit();
            this.tabTransactionLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLog)).BeginInit();
            this.tabTransferLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 721);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormForBank.Properties.Resources.iconOfbank;
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblDateTime.Location = new System.Drawing.Point(11, 287);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 22);
            this.lblDateTime.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentUser.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblCurrentUser.Location = new System.Drawing.Point(11, 255);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(108, 23);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Welcome,";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(327, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 711);
            this.panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDeposit);
            this.tabControl1.Controls.Add(this.tabWithdraw);
            this.tabControl1.Controls.Add(this.tabTotalBalances);
            this.tabControl1.Controls.Add(this.tabTransferBalances);
            this.tabControl1.Controls.Add(this.tabTransactionLog);
            this.tabControl1.Controls.Add(this.tabTransferLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1463, 711);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDeposit
            // 
            this.tabDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabDeposit.Controls.Add(this.lblCurrentBalance);
            this.tabDeposit.Controls.Add(this.lblBalance);
            this.tabDeposit.Controls.Add(this.btnDeposit);
            this.tabDeposit.Controls.Add(this.numDepositAmount);
            this.tabDeposit.Controls.Add(this.label2);
            this.tabDeposit.Controls.Add(this.label1);
            this.tabDeposit.Controls.Add(this.cobDepositAccNumbers);
            this.tabDeposit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabDeposit.ImageIndex = 0;
            this.tabDeposit.Location = new System.Drawing.Point(4, 47);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposit.Size = new System.Drawing.Size(1455, 660);
            this.tabDeposit.TabIndex = 0;
            this.tabDeposit.Text = "Deposit";
            this.tabDeposit.UseVisualStyleBackColor = true;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCurrentBalance.Location = new System.Drawing.Point(367, 194);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(0, 44);
            this.lblCurrentBalance.TabIndex = 8;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBalance.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBalance.Location = new System.Drawing.Point(78, 201);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(263, 32);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Current Balance: ";
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnDeposit.Location = new System.Drawing.Point(78, 421);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(263, 52);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            this.btnDeposit.MouseLeave += new System.EventHandler(this.btnDeposit_MouseLeave);
            this.btnDeposit.MouseHover += new System.EventHandler(this.btnDeposit_MouseHover);
            // 
            // numDepositAmount
            // 
            this.numDepositAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numDepositAmount.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.numDepositAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDepositAmount.Location = new System.Drawing.Point(77, 310);
            this.numDepositAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDepositAmount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDepositAmount.Name = "numDepositAmount";
            this.numDepositAmount.Size = new System.Drawing.Size(264, 30);
            this.numDepositAmount.TabIndex = 5;
            this.numDepositAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(72, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deposit Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(73, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Number";
            // 
            // cobDepositAccNumbers
            // 
            this.cobDepositAccNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobDepositAccNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobDepositAccNumbers.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobDepositAccNumbers.ForeColor = System.Drawing.Color.Black;
            this.cobDepositAccNumbers.FormattingEnabled = true;
            this.cobDepositAccNumbers.Location = new System.Drawing.Point(77, 130);
            this.cobDepositAccNumbers.Name = "cobDepositAccNumbers";
            this.cobDepositAccNumbers.Size = new System.Drawing.Size(264, 30);
            this.cobDepositAccNumbers.Sorted = true;
            this.cobDepositAccNumbers.TabIndex = 0;
            this.cobDepositAccNumbers.SelectedIndexChanged += new System.EventHandler(this.cobAccNumbers_SelectedIndexChanged);
            // 
            // tabWithdraw
            // 
            this.tabWithdraw.Controls.Add(this.lblCurrentBalanceAfterWithDraw);
            this.tabWithdraw.Controls.Add(this.lablBalance1);
            this.tabWithdraw.Controls.Add(this.btnWithdraw);
            this.tabWithdraw.Controls.Add(this.numWithdraw);
            this.tabWithdraw.Controls.Add(this.label5);
            this.tabWithdraw.Controls.Add(this.label6);
            this.tabWithdraw.Controls.Add(this.cobxWithDraw);
            this.tabWithdraw.ImageIndex = 4;
            this.tabWithdraw.Location = new System.Drawing.Point(4, 47);
            this.tabWithdraw.Name = "tabWithdraw";
            this.tabWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabWithdraw.Size = new System.Drawing.Size(1455, 660);
            this.tabWithdraw.TabIndex = 1;
            this.tabWithdraw.Text = "Withdraw";
            this.tabWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblCurrentBalanceAfterWithDraw
            // 
            this.lblCurrentBalanceAfterWithDraw.AutoSize = true;
            this.lblCurrentBalanceAfterWithDraw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentBalanceAfterWithDraw.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceAfterWithDraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCurrentBalanceAfterWithDraw.Location = new System.Drawing.Point(375, 190);
            this.lblCurrentBalanceAfterWithDraw.Name = "lblCurrentBalanceAfterWithDraw";
            this.lblCurrentBalanceAfterWithDraw.Size = new System.Drawing.Size(0, 44);
            this.lblCurrentBalanceAfterWithDraw.TabIndex = 15;
            // 
            // lablBalance1
            // 
            this.lablBalance1.AutoSize = true;
            this.lablBalance1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lablBalance1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablBalance1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lablBalance1.Location = new System.Drawing.Point(77, 202);
            this.lablBalance1.Name = "lablBalance1";
            this.lablBalance1.Size = new System.Drawing.Size(263, 32);
            this.lablBalance1.TabIndex = 14;
            this.lablBalance1.Text = "Current Balance: ";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnWithdraw.Location = new System.Drawing.Point(77, 422);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(263, 52);
            this.btnWithdraw.TabIndex = 13;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            this.btnWithdraw.MouseLeave += new System.EventHandler(this.btnWithdraw_MouseLeave);
            this.btnWithdraw.MouseHover += new System.EventHandler(this.btnWithdraw_MouseHover);
            // 
            // numWithdraw
            // 
            this.numWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numWithdraw.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.numWithdraw.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWithdraw.Location = new System.Drawing.Point(76, 311);
            this.numWithdraw.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numWithdraw.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWithdraw.Name = "numWithdraw";
            this.numWithdraw.Size = new System.Drawing.Size(264, 30);
            this.numWithdraw.TabIndex = 12;
            this.numWithdraw.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWithdraw.ValueChanged += new System.EventHandler(this.numWithdraw_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(71, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Withdraw Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(72, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Account Number";
            // 
            // cobxWithDraw
            // 
            this.cobxWithDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobxWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobxWithDraw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobxWithDraw.ForeColor = System.Drawing.Color.Black;
            this.cobxWithDraw.FormattingEnabled = true;
            this.cobxWithDraw.Location = new System.Drawing.Point(76, 131);
            this.cobxWithDraw.Name = "cobxWithDraw";
            this.cobxWithDraw.Size = new System.Drawing.Size(264, 30);
            this.cobxWithDraw.Sorted = true;
            this.cobxWithDraw.TabIndex = 9;
            this.cobxWithDraw.SelectedIndexChanged += new System.EventHandler(this.cobxWithDraw_SelectedIndexChanged);
            // 
            // tabTotalBalances
            // 
            this.tabTotalBalances.BackColor = System.Drawing.Color.White;
            this.tabTotalBalances.Controls.Add(this.txtbSearch);
            this.tabTotalBalances.Controls.Add(this.label4);
            this.tabTotalBalances.Controls.Add(this.dgvBalances);
            this.tabTotalBalances.Controls.Add(this.panel3);
            this.tabTotalBalances.ImageIndex = 2;
            this.tabTotalBalances.Location = new System.Drawing.Point(4, 47);
            this.tabTotalBalances.Name = "tabTotalBalances";
            this.tabTotalBalances.Size = new System.Drawing.Size(1455, 660);
            this.tabTotalBalances.TabIndex = 2;
            this.tabTotalBalances.Text = "Total Balances";
            this.tabTotalBalances.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabTotalBalances_MouseClick);
            // 
            // txtbSearch
            // 
            this.txtbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtbSearch.Location = new System.Drawing.Point(215, 201);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(234, 30);
            this.txtbSearch.TabIndex = 4;
            this.txtbSearch.TextChanged += new System.EventHandler(this.txtbSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(211, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search By Account No";
            // 
            // dgvBalances
            // 
            this.dgvBalances.AllowUserToAddRows = false;
            this.dgvBalances.AllowUserToDeleteRows = false;
            this.dgvBalances.AllowUserToOrderColumns = true;
            this.dgvBalances.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBalances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBalances.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBalances.EnableHeadersVisualStyles = false;
            this.dgvBalances.Location = new System.Drawing.Point(215, 240);
            this.dgvBalances.Name = "dgvBalances";
            this.dgvBalances.ReadOnly = true;
            this.dgvBalances.RowHeadersWidth = 51;
            this.dgvBalances.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBalances.RowTemplate.Height = 24;
            this.dgvBalances.Size = new System.Drawing.Size(816, 408);
            this.dgvBalances.TabIndex = 1;
            this.dgvBalances.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBalances_DataBindingComplete);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lblTotalBalancesInString);
            this.panel3.Controls.Add(this.lblTotalBalances);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(118, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 114);
            this.panel3.TabIndex = 0;
            // 
            // lblTotalBalancesInString
            // 
            this.lblTotalBalancesInString.AutoSize = true;
            this.lblTotalBalancesInString.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBalancesInString.Font = new System.Drawing.Font("Elephant", 16.2F);
            this.lblTotalBalancesInString.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBalancesInString.Location = new System.Drawing.Point(45, 64);
            this.lblTotalBalancesInString.Name = "lblTotalBalancesInString";
            this.lblTotalBalancesInString.Size = new System.Drawing.Size(0, 37);
            this.lblTotalBalancesInString.TabIndex = 5;
            // 
            // lblTotalBalances
            // 
            this.lblTotalBalances.AutoSize = true;
            this.lblTotalBalances.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBalances.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalBalances.Location = new System.Drawing.Point(564, 14);
            this.lblTotalBalances.Name = "lblTotalBalances";
            this.lblTotalBalances.Size = new System.Drawing.Size(0, 37);
            this.lblTotalBalances.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(330, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Balances: ";
            // 
            // tabTransferBalances
            // 
            this.tabTransferBalances.Controls.Add(this.btnTransfer);
            this.tabTransferBalances.Controls.Add(this.label10);
            this.tabTransferBalances.Controls.Add(this.numTransfer);
            this.tabTransferBalances.Controls.Add(this.lblDesBalance);
            this.tabTransferBalances.Controls.Add(this.label11);
            this.tabTransferBalances.Controls.Add(this.lblSrcBalance);
            this.tabTransferBalances.Controls.Add(this.label9);
            this.tabTransferBalances.Controls.Add(this.label8);
            this.tabTransferBalances.Controls.Add(this.cobxDestinationAccNumber);
            this.tabTransferBalances.Controls.Add(this.label7);
            this.tabTransferBalances.Controls.Add(this.cobxSourceAcc);
            this.tabTransferBalances.ImageIndex = 3;
            this.tabTransferBalances.Location = new System.Drawing.Point(4, 47);
            this.tabTransferBalances.Name = "tabTransferBalances";
            this.tabTransferBalances.Size = new System.Drawing.Size(1455, 660);
            this.tabTransferBalances.TabIndex = 3;
            this.tabTransferBalances.Text = "Transfer Balances";
            this.tabTransferBalances.UseVisualStyleBackColor = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnTransfer.Location = new System.Drawing.Point(543, 439);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(256, 51);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(539, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Transfer Amount";
            // 
            // numTransfer
            // 
            this.numTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numTransfer.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.numTransfer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTransfer.Location = new System.Drawing.Point(543, 311);
            this.numTransfer.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTransfer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTransfer.Name = "numTransfer";
            this.numTransfer.Size = new System.Drawing.Size(256, 30);
            this.numTransfer.TabIndex = 9;
            this.numTransfer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTransfer.ValueChanged += new System.EventHandler(this.numTransfer_ValueChanged);
            // 
            // lblDesBalance
            // 
            this.lblDesBalance.AutoSize = true;
            this.lblDesBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDesBalance.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDesBalance.Location = new System.Drawing.Point(999, 176);
            this.lblDesBalance.Name = "lblDesBalance";
            this.lblDesBalance.Size = new System.Drawing.Size(0, 30);
            this.lblDesBalance.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(787, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Current Balance: ";
            // 
            // lblSrcBalance
            // 
            this.lblSrcBalance.AutoSize = true;
            this.lblSrcBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSrcBalance.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrcBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSrcBalance.Location = new System.Drawing.Point(521, 176);
            this.lblSrcBalance.Name = "lblSrcBalance";
            this.lblSrcBalance.Size = new System.Drawing.Size(0, 30);
            this.lblSrcBalance.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(313, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Current Balance: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(788, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "To Account Number";
            // 
            // cobxDestinationAccNumber
            // 
            this.cobxDestinationAccNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobxDestinationAccNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobxDestinationAccNumber.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.cobxDestinationAccNumber.FormattingEnabled = true;
            this.cobxDestinationAccNumber.Location = new System.Drawing.Point(792, 123);
            this.cobxDestinationAccNumber.Name = "cobxDestinationAccNumber";
            this.cobxDestinationAccNumber.Size = new System.Drawing.Size(245, 30);
            this.cobxDestinationAccNumber.TabIndex = 4;
            this.cobxDestinationAccNumber.SelectedIndexChanged += new System.EventHandler(this.cobxDestinationAccNumber_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(314, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "From Account Number";
            // 
            // cobxSourceAcc
            // 
            this.cobxSourceAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobxSourceAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobxSourceAcc.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.cobxSourceAcc.FormattingEnabled = true;
            this.cobxSourceAcc.Location = new System.Drawing.Point(316, 123);
            this.cobxSourceAcc.Name = "cobxSourceAcc";
            this.cobxSourceAcc.Size = new System.Drawing.Size(245, 30);
            this.cobxSourceAcc.TabIndex = 0;
            this.cobxSourceAcc.SelectedIndexChanged += new System.EventHandler(this.cobxSourceAcc_SelectedIndexChanged_1);
            // 
            // tabTransactionLog
            // 
            this.tabTransactionLog.Controls.Add(this.txtbTranscionLog);
            this.tabTransactionLog.Controls.Add(this.label12);
            this.tabTransactionLog.Controls.Add(this.dgvTransactionLog);
            this.tabTransactionLog.ImageIndex = 6;
            this.tabTransactionLog.Location = new System.Drawing.Point(4, 47);
            this.tabTransactionLog.Name = "tabTransactionLog";
            this.tabTransactionLog.Size = new System.Drawing.Size(1455, 660);
            this.tabTransactionLog.TabIndex = 5;
            this.tabTransactionLog.Text = "Transactions Log";
            this.tabTransactionLog.UseVisualStyleBackColor = true;
            // 
            // txtbTranscionLog
            // 
            this.txtbTranscionLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbTranscionLog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtbTranscionLog.Location = new System.Drawing.Point(204, 80);
            this.txtbTranscionLog.Name = "txtbTranscionLog";
            this.txtbTranscionLog.Size = new System.Drawing.Size(234, 30);
            this.txtbTranscionLog.TabIndex = 6;
            this.txtbTranscionLog.TextChanged += new System.EventHandler(this.txtbTranscionLog_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label12.Location = new System.Drawing.Point(201, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Search By Account No";
            // 
            // dgvTransactionLog
            // 
            this.dgvTransactionLog.AllowUserToAddRows = false;
            this.dgvTransactionLog.AllowUserToDeleteRows = false;
            this.dgvTransactionLog.AllowUserToOrderColumns = true;
            this.dgvTransactionLog.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactionLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionLog.EnableHeadersVisualStyles = false;
            this.dgvTransactionLog.Location = new System.Drawing.Point(204, 116);
            this.dgvTransactionLog.Name = "dgvTransactionLog";
            this.dgvTransactionLog.ReadOnly = true;
            this.dgvTransactionLog.RowHeadersWidth = 51;
            this.dgvTransactionLog.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactionLog.RowTemplate.Height = 24;
            this.dgvTransactionLog.Size = new System.Drawing.Size(960, 505);
            this.dgvTransactionLog.TabIndex = 0;
            this.dgvTransactionLog.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTransactionLog_DataBindingComplete);
            // 
            // tabTransferLog
            // 
            this.tabTransferLog.Controls.Add(this.dgvTransferLog);
            this.tabTransferLog.Controls.Add(this.txtbSearchTransferLog);
            this.tabTransferLog.Controls.Add(this.label13);
            this.tabTransferLog.ImageIndex = 6;
            this.tabTransferLog.Location = new System.Drawing.Point(4, 47);
            this.tabTransferLog.Name = "tabTransferLog";
            this.tabTransferLog.Size = new System.Drawing.Size(1455, 660);
            this.tabTransferLog.TabIndex = 4;
            this.tabTransferLog.Text = "Transfer Log";
            this.tabTransferLog.UseVisualStyleBackColor = true;
            // 
            // dgvTransferLog
            // 
            this.dgvTransferLog.AllowUserToAddRows = false;
            this.dgvTransferLog.AllowUserToDeleteRows = false;
            this.dgvTransferLog.AllowUserToOrderColumns = true;
            this.dgvTransferLog.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTransferLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferLog.EnableHeadersVisualStyles = false;
            this.dgvTransferLog.Location = new System.Drawing.Point(3, 119);
            this.dgvTransferLog.Name = "dgvTransferLog";
            this.dgvTransferLog.ReadOnly = true;
            this.dgvTransferLog.RowHeadersWidth = 51;
            this.dgvTransferLog.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransferLog.RowTemplate.Height = 24;
            this.dgvTransferLog.Size = new System.Drawing.Size(1431, 505);
            this.dgvTransferLog.TabIndex = 7;
            this.dgvTransferLog.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTransferLog_DataBindingComplete);
            // 
            // txtbSearchTransferLog
            // 
            this.txtbSearchTransferLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbSearchTransferLog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtbSearchTransferLog.Location = new System.Drawing.Point(40, 73);
            this.txtbSearchTransferLog.Name = "txtbSearchTransferLog";
            this.txtbSearchTransferLog.Size = new System.Drawing.Size(234, 30);
            this.txtbSearchTransferLog.TabIndex = 6;
            this.txtbSearchTransferLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label13.Location = new System.Drawing.Point(36, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "Search By Account No";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "deposit.icon.png");
            this.imageList1.Images.SetKeyName(1, "login Register.png");
            this.imageList1.Images.SetKeyName(2, "totalBalances.icon.png");
            this.imageList1.Images.SetKeyName(3, "transferBalances.icon.jpeg");
            this.imageList1.Images.SetKeyName(4, "withdraw.icon.png");
            this.imageList1.Images.SetKeyName(5, "picture.png");
            this.imageList1.Images.SetKeyName(6, "logs.icon.png");
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1802, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDeposit.ResumeLayout(false);
            this.tabDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositAmount)).EndInit();
            this.tabWithdraw.ResumeLayout(false);
            this.tabWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdraw)).EndInit();
            this.tabTotalBalances.ResumeLayout(false);
            this.tabTotalBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabTransferBalances.ResumeLayout(false);
            this.tabTransferBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTransfer)).EndInit();
            this.tabTransactionLog.ResumeLayout(false);
            this.tabTransactionLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLog)).EndInit();
            this.tabTransferLog.ResumeLayout(false);
            this.tabTransferLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.NumericUpDown numDepositAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobDepositAccNumbers;
        private System.Windows.Forms.TabPage tabWithdraw;
        private System.Windows.Forms.Label lblCurrentBalanceAfterWithDraw;
        private System.Windows.Forms.Label lablBalance1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.NumericUpDown numWithdraw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cobxWithDraw;
        private System.Windows.Forms.TabPage tabTotalBalances;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBalances;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBalancesInString;
        private System.Windows.Forms.Label lblTotalBalances;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabTransferBalances;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numTransfer;
        private System.Windows.Forms.Label lblDesBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSrcBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cobxDestinationAccNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cobxSourceAcc;
        private System.Windows.Forms.TabPage tabTransactionLog;
        private System.Windows.Forms.TabPage tabTransferLog;
        private System.Windows.Forms.DataGridView dgvTransactionLog;
        private System.Windows.Forms.TextBox txtbTranscionLog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbSearchTransferLog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvTransferLog;
    }
}
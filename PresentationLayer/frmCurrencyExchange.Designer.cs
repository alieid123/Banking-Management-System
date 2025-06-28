namespace WinFormForBank
{
    partial class frmCurrencyExchange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrencyExchange));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabShowCurrencies = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvOfCurrenciesList = new System.Windows.Forms.DataGridView();
            this.lblNoOfAllClients = new System.Windows.Forms.Label();
            this.tabUpdateCurrency = new System.Windows.Forms.TabPage();
            this.lblCurrencyDetails = new System.Windows.Forms.Label();
            this.btnUpdateCurrency = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpdateCurrency = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cobxCurrenciesCode = new System.Windows.Forms.ComboBox();
            this.tabCurrencyExchange = new System.Windows.Forms.TabPage();
            this.lblExchange = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numAmountToExchange = new System.Windows.Forms.NumericUpDown();
            this.lblDestinationCurrencyInfo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cobxDestinationCurrency = new System.Windows.Forms.ComboBox();
            this.lblSourceCurrencyInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cobxSourceCurrency = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabShowCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfCurrenciesList)).BeginInit();
            this.tabUpdateCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCurrency)).BeginInit();
            this.tabCurrencyExchange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountToExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 721);
            this.panel1.TabIndex = 3;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabShowCurrencies);
            this.tabControl1.Controls.Add(this.tabUpdateCurrency);
            this.tabControl1.Controls.Add(this.tabCurrencyExchange);
            this.tabControl1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(347, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 721);
            this.tabControl1.TabIndex = 4;
            // 
            // tabShowCurrencies
            // 
            this.tabShowCurrencies.Controls.Add(this.label10);
            this.tabShowCurrencies.Controls.Add(this.label1);
            this.tabShowCurrencies.Controls.Add(this.txtSearch);
            this.tabShowCurrencies.Controls.Add(this.dgvOfCurrenciesList);
            this.tabShowCurrencies.Controls.Add(this.lblNoOfAllClients);
            this.tabShowCurrencies.ImageIndex = 0;
            this.tabShowCurrencies.Location = new System.Drawing.Point(4, 47);
            this.tabShowCurrencies.Name = "tabShowCurrencies";
            this.tabShowCurrencies.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowCurrencies.Size = new System.Drawing.Size(997, 670);
            this.tabShowCurrencies.TabIndex = 0;
            this.tabShowCurrencies.Text = "Currencies";
            this.tabShowCurrencies.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(780, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Search By Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(706, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.txtSearch.Location = new System.Drawing.Point(755, 83);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(216, 39);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvOfCurrenciesList
            // 
            this.dgvOfCurrenciesList.AllowUserToAddRows = false;
            this.dgvOfCurrenciesList.AllowUserToDeleteRows = false;
            this.dgvOfCurrenciesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvOfCurrenciesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOfCurrenciesList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOfCurrenciesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOfCurrenciesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfCurrenciesList.EnableHeadersVisualStyles = false;
            this.dgvOfCurrenciesList.Location = new System.Drawing.Point(6, 128);
            this.dgvOfCurrenciesList.Name = "dgvOfCurrenciesList";
            this.dgvOfCurrenciesList.ReadOnly = true;
            this.dgvOfCurrenciesList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvOfCurrenciesList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOfCurrenciesList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOfCurrenciesList.RowTemplate.Height = 24;
            this.dgvOfCurrenciesList.Size = new System.Drawing.Size(985, 486);
            this.dgvOfCurrenciesList.TabIndex = 8;
            this.dgvOfCurrenciesList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOfCurrenciesList_DataBindingComplete);
            // 
            // lblNoOfAllClients
            // 
            this.lblNoOfAllClients.AutoSize = true;
            this.lblNoOfAllClients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNoOfAllClients.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfAllClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblNoOfAllClients.Location = new System.Drawing.Point(17, 61);
            this.lblNoOfAllClients.Name = "lblNoOfAllClients";
            this.lblNoOfAllClients.Size = new System.Drawing.Size(0, 32);
            this.lblNoOfAllClients.TabIndex = 7;
            // 
            // tabUpdateCurrency
            // 
            this.tabUpdateCurrency.Controls.Add(this.lblCurrencyDetails);
            this.tabUpdateCurrency.Controls.Add(this.btnUpdateCurrency);
            this.tabUpdateCurrency.Controls.Add(this.label2);
            this.tabUpdateCurrency.Controls.Add(this.numUpdateCurrency);
            this.tabUpdateCurrency.Controls.Add(this.label3);
            this.tabUpdateCurrency.Controls.Add(this.cobxCurrenciesCode);
            this.tabUpdateCurrency.ImageIndex = 1;
            this.tabUpdateCurrency.Location = new System.Drawing.Point(4, 47);
            this.tabUpdateCurrency.Name = "tabUpdateCurrency";
            this.tabUpdateCurrency.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateCurrency.Size = new System.Drawing.Size(997, 670);
            this.tabUpdateCurrency.TabIndex = 1;
            this.tabUpdateCurrency.Text = "Update Currency";
            this.tabUpdateCurrency.UseVisualStyleBackColor = true;
            // 
            // lblCurrencyDetails
            // 
            this.lblCurrencyDetails.AutoSize = true;
            this.lblCurrencyDetails.BackColor = System.Drawing.Color.White;
            this.lblCurrencyDetails.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblCurrencyDetails.Location = new System.Drawing.Point(340, 167);
            this.lblCurrencyDetails.Name = "lblCurrencyDetails";
            this.lblCurrencyDetails.Size = new System.Drawing.Size(0, 26);
            this.lblCurrencyDetails.TabIndex = 10;
            // 
            // btnUpdateCurrency
            // 
            this.btnUpdateCurrency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnUpdateCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCurrency.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnUpdateCurrency.Location = new System.Drawing.Point(340, 464);
            this.btnUpdateCurrency.Name = "btnUpdateCurrency";
            this.btnUpdateCurrency.Size = new System.Drawing.Size(264, 57);
            this.btnUpdateCurrency.TabIndex = 9;
            this.btnUpdateCurrency.Text = "Update Rate";
            this.btnUpdateCurrency.UseVisualStyleBackColor = true;
            this.btnUpdateCurrency.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(340, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Rate ($)";
            // 
            // numUpdateCurrency
            // 
            this.numUpdateCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numUpdateCurrency.DecimalPlaces = 5;
            this.numUpdateCurrency.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.numUpdateCurrency.Location = new System.Drawing.Point(340, 357);
            this.numUpdateCurrency.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUpdateCurrency.Name = "numUpdateCurrency";
            this.numUpdateCurrency.Size = new System.Drawing.Size(264, 30);
            this.numUpdateCurrency.TabIndex = 7;
            this.numUpdateCurrency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(340, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search By Code";
            // 
            // cobxCurrenciesCode
            // 
            this.cobxCurrenciesCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobxCurrenciesCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobxCurrenciesCode.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobxCurrenciesCode.ForeColor = System.Drawing.Color.Black;
            this.cobxCurrenciesCode.FormattingEnabled = true;
            this.cobxCurrenciesCode.Location = new System.Drawing.Point(340, 92);
            this.cobxCurrenciesCode.Name = "cobxCurrenciesCode";
            this.cobxCurrenciesCode.Size = new System.Drawing.Size(264, 30);
            this.cobxCurrenciesCode.Sorted = true;
            this.cobxCurrenciesCode.TabIndex = 4;
            this.cobxCurrenciesCode.SelectedIndexChanged += new System.EventHandler(this.cobxCurrenciesCode_SelectedIndexChanged);
            // 
            // tabCurrencyExchange
            // 
            this.tabCurrencyExchange.Controls.Add(this.lblExchange);
            this.tabCurrencyExchange.Controls.Add(this.btnExchange);
            this.tabCurrencyExchange.Controls.Add(this.label4);
            this.tabCurrencyExchange.Controls.Add(this.numAmountToExchange);
            this.tabCurrencyExchange.Controls.Add(this.lblDestinationCurrencyInfo);
            this.tabCurrencyExchange.Controls.Add(this.label7);
            this.tabCurrencyExchange.Controls.Add(this.cobxDestinationCurrency);
            this.tabCurrencyExchange.Controls.Add(this.lblSourceCurrencyInfo);
            this.tabCurrencyExchange.Controls.Add(this.label5);
            this.tabCurrencyExchange.Controls.Add(this.cobxSourceCurrency);
            this.tabCurrencyExchange.ImageIndex = 2;
            this.tabCurrencyExchange.Location = new System.Drawing.Point(4, 47);
            this.tabCurrencyExchange.Name = "tabCurrencyExchange";
            this.tabCurrencyExchange.Size = new System.Drawing.Size(997, 670);
            this.tabCurrencyExchange.TabIndex = 2;
            this.tabCurrencyExchange.Text = "Currency Exchange";
            this.tabCurrencyExchange.UseVisualStyleBackColor = true;
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblExchange.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblExchange.Location = new System.Drawing.Point(305, 527);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(0, 27);
            this.lblExchange.TabIndex = 20;
            // 
            // btnExchange
            // 
            this.btnExchange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnExchange.Location = new System.Drawing.Point(354, 417);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(264, 57);
            this.btnExchange.TabIndex = 19;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(349, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount";
            // 
            // numAmountToExchange
            // 
            this.numAmountToExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numAmountToExchange.DecimalPlaces = 5;
            this.numAmountToExchange.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.numAmountToExchange.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAmountToExchange.Location = new System.Drawing.Point(354, 349);
            this.numAmountToExchange.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numAmountToExchange.Name = "numAmountToExchange";
            this.numAmountToExchange.Size = new System.Drawing.Size(264, 30);
            this.numAmountToExchange.TabIndex = 17;
            this.numAmountToExchange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDestinationCurrencyInfo
            // 
            this.lblDestinationCurrencyInfo.AutoSize = true;
            this.lblDestinationCurrencyInfo.BackColor = System.Drawing.Color.White;
            this.lblDestinationCurrencyInfo.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCurrencyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblDestinationCurrencyInfo.Location = new System.Drawing.Point(618, 167);
            this.lblDestinationCurrencyInfo.Name = "lblDestinationCurrencyInfo";
            this.lblDestinationCurrencyInfo.Size = new System.Drawing.Size(0, 26);
            this.lblDestinationCurrencyInfo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(618, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Convert To";
            // 
            // cobxDestinationCurrency
            // 
            this.cobxDestinationCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobxDestinationCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobxDestinationCurrency.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobxDestinationCurrency.ForeColor = System.Drawing.Color.Black;
            this.cobxDestinationCurrency.FormattingEnabled = true;
            this.cobxDestinationCurrency.Location = new System.Drawing.Point(618, 92);
            this.cobxDestinationCurrency.Name = "cobxDestinationCurrency";
            this.cobxDestinationCurrency.Size = new System.Drawing.Size(264, 30);
            this.cobxDestinationCurrency.Sorted = true;
            this.cobxDestinationCurrency.TabIndex = 14;
            this.cobxDestinationCurrency.SelectedIndexChanged += new System.EventHandler(this.cobxDestinationCurrency_SelectedIndexChanged);
            // 
            // lblSourceCurrencyInfo
            // 
            this.lblSourceCurrencyInfo.AutoSize = true;
            this.lblSourceCurrencyInfo.BackColor = System.Drawing.Color.White;
            this.lblSourceCurrencyInfo.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceCurrencyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblSourceCurrencyInfo.Location = new System.Drawing.Point(118, 167);
            this.lblSourceCurrencyInfo.Name = "lblSourceCurrencyInfo";
            this.lblSourceCurrencyInfo.Size = new System.Drawing.Size(0, 26);
            this.lblSourceCurrencyInfo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(118, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Convert From";
            // 
            // cobxSourceCurrency
            // 
            this.cobxSourceCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cobxSourceCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobxSourceCurrency.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobxSourceCurrency.ForeColor = System.Drawing.Color.Black;
            this.cobxSourceCurrency.FormattingEnabled = true;
            this.cobxSourceCurrency.Location = new System.Drawing.Point(118, 92);
            this.cobxSourceCurrency.Name = "cobxSourceCurrency";
            this.cobxSourceCurrency.Size = new System.Drawing.Size(264, 30);
            this.cobxSourceCurrency.Sorted = true;
            this.cobxSourceCurrency.TabIndex = 11;
            this.cobxSourceCurrency.SelectedIndexChanged += new System.EventHandler(this.cobxSourceCurrency_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Currencies.icon.png");
            this.imageList1.Images.SetKeyName(1, "updateCurrency.icon.png");
            this.imageList1.Images.SetKeyName(2, "exchangeCurrencies.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1364, 747);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCurrencyExchange";
            this.Text = "frmCurrencyExchange";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabShowCurrencies.ResumeLayout(false);
            this.tabShowCurrencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfCurrenciesList)).EndInit();
            this.tabUpdateCurrency.ResumeLayout(false);
            this.tabUpdateCurrency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCurrency)).EndInit();
            this.tabCurrencyExchange.ResumeLayout(false);
            this.tabCurrencyExchange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountToExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabShowCurrencies;
        private System.Windows.Forms.TabPage tabCurrencyExchange;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNoOfAllClients;
        private System.Windows.Forms.DataGridView dgvOfCurrenciesList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabUpdateCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobxCurrenciesCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpdateCurrency;
        private System.Windows.Forms.Label lblCurrencyDetails;
        private System.Windows.Forms.Button btnUpdateCurrency;
        private System.Windows.Forms.Label lblSourceCurrencyInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cobxSourceCurrency;
        private System.Windows.Forms.Label lblDestinationCurrencyInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cobxDestinationCurrency;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAmountToExchange;
        private System.Windows.Forms.Label lblExchange;
    }
}
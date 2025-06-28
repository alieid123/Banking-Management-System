namespace WinFormForBank
{
    partial class frmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnListClients = new System.Windows.Forms.Button();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabListClients = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNoOfAllClients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvListClients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAddUpdateFindClient = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtbSearchClient = new System.Windows.Forms.TextBox();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.txtbAccNo = new System.Windows.Forms.TextBox();
            this.txtbPinCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.lblAddUpdateFindClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabListClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabAddUpdateFindClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnUpdateClient);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.btnListClients);
            this.panel1.Controls.Add(this.btnAddNewClient);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.btnFindClient);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 721);
            this.panel1.TabIndex = 2;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.White;
            this.btnUpdateClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnUpdateClient.FlatAppearance.BorderSize = 0;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateClient.ImageIndex = 3;
            this.btnUpdateClient.ImageList = this.imageList1;
            this.btnUpdateClient.Location = new System.Drawing.Point(8, 499);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(309, 59);
            this.btnUpdateClient.TabIndex = 3;
            this.btnUpdateClient.Text = "   Update Client";
            this.btnUpdateClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Iconlist.png");
            this.imageList1.Images.SetKeyName(1, "IconAddNew.png");
            this.imageList1.Images.SetKeyName(2, "icondelete.png");
            this.imageList1.Images.SetKeyName(3, "iconUpdate.png");
            this.imageList1.Images.SetKeyName(4, "IconSave.png");
            this.imageList1.Images.SetKeyName(5, "IconFind.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormForBank.Properties.Resources.iconOfbank;
            this.pictureBox1.Location = new System.Drawing.Point(3, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 130);
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
            this.lblDateTime.Location = new System.Drawing.Point(11, 240);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 22);
            this.lblDateTime.TabIndex = 1;
            // 
            // btnListClients
            // 
            this.btnListClients.BackColor = System.Drawing.Color.White;
            this.btnListClients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnListClients.FlatAppearance.BorderSize = 0;
            this.btnListClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListClients.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListClients.ImageIndex = 0;
            this.btnListClients.ImageList = this.imageList1;
            this.btnListClients.Location = new System.Drawing.Point(8, 321);
            this.btnListClients.Name = "btnListClients";
            this.btnListClients.Size = new System.Drawing.Size(309, 59);
            this.btnListClients.TabIndex = 1;
            this.btnListClients.Text = "    Clients List ";
            this.btnListClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListClients.UseVisualStyleBackColor = false;
            this.btnListClients.Click += new System.EventHandler(this.btnListClients_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.BackColor = System.Drawing.Color.White;
            this.btnAddNewClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnAddNewClient.FlatAppearance.BorderSize = 0;
            this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClient.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewClient.ImageIndex = 1;
            this.btnAddNewClient.ImageList = this.imageList1;
            this.btnAddNewClient.Location = new System.Drawing.Point(8, 410);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(309, 59);
            this.btnAddNewClient.TabIndex = 2;
            this.btnAddNewClient.Text = "   Add New Client";
            this.btnAddNewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewClient.UseVisualStyleBackColor = false;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentUser.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblCurrentUser.Location = new System.Drawing.Point(11, 208);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(108, 23);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Welcome,";
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackColor = System.Drawing.Color.White;
            this.btnFindClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.ImageIndex = 5;
            this.btnFindClient.ImageList = this.imageList1;
            this.btnFindClient.Location = new System.Drawing.Point(8, 588);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(309, 59);
            this.btnFindClient.TabIndex = 4;
            this.btnFindClient.Text = "    Find Client";
            this.btnFindClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindClient.UseVisualStyleBackColor = false;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabListClients);
            this.tabControl1.Controls.Add(this.tabAddUpdateFindClient);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1396, 747);
            this.tabControl1.TabIndex = 3;
            // 
            // tabListClients
            // 
            this.tabListClients.Controls.Add(this.label11);
            this.tabListClients.Controls.Add(this.label10);
            this.tabListClients.Controls.Add(this.lblNoOfAllClients);
            this.tabListClients.Controls.Add(this.label1);
            this.tabListClients.Controls.Add(this.pictureBox2);
            this.tabListClients.Controls.Add(this.txtSearch);
            this.tabListClients.Controls.Add(this.dgvListClients);
            this.tabListClients.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListClients.Location = new System.Drawing.Point(4, 26);
            this.tabListClients.Name = "tabListClients";
            this.tabListClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabListClients.Size = new System.Drawing.Size(1388, 717);
            this.tabListClients.TabIndex = 0;
            this.tabListClients.Text = "Clients List";
            this.tabListClients.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(521, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 46);
            this.label11.TabIndex = 7;
            this.label11.Text = "Clients List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(944, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Search By Account No";
            // 
            // lblNoOfAllClients
            // 
            this.lblNoOfAllClients.AutoSize = true;
            this.lblNoOfAllClients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNoOfAllClients.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfAllClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblNoOfAllClients.Location = new System.Drawing.Point(19, 103);
            this.lblNoOfAllClients.Name = "lblNoOfAllClients";
            this.lblNoOfAllClients.Size = new System.Drawing.Size(0, 32);
            this.lblNoOfAllClients.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(938, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WinFormForBank.Properties.Resources.IconSearch;
            this.pictureBox2.Location = new System.Drawing.Point(1188, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.txtSearch.Location = new System.Drawing.Point(942, 119);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvListClients
            // 
            this.dgvListClients.AllowUserToAddRows = false;
            this.dgvListClients.AllowUserToDeleteRows = false;
            this.dgvListClients.AllowUserToOrderColumns = true;
            this.dgvListClients.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListClients.EnableHeadersVisualStyles = false;
            this.dgvListClients.Location = new System.Drawing.Point(3, 176);
            this.dgvListClients.Name = "dgvListClients";
            this.dgvListClients.ReadOnly = true;
            this.dgvListClients.RowHeadersWidth = 51;
            this.dgvListClients.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListClients.RowTemplate.Height = 24;
            this.dgvListClients.Size = new System.Drawing.Size(1326, 538);
            this.dgvListClients.TabIndex = 0;
            this.dgvListClients.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListClients_DataBindingComplete);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.updateToolStripMenuItem.Text = "Edit";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tabAddUpdateFindClient
            // 
            this.tabAddUpdateFindClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAddUpdateFindClient.Controls.Add(this.btnSearch);
            this.tabAddUpdateFindClient.Controls.Add(this.pictureBox3);
            this.tabAddUpdateFindClient.Controls.Add(this.lblSearch);
            this.tabAddUpdateFindClient.Controls.Add(this.txtbSearchClient);
            this.tabAddUpdateFindClient.Controls.Add(this.txtbPhone);
            this.tabAddUpdateFindClient.Controls.Add(this.txtbAccNo);
            this.tabAddUpdateFindClient.Controls.Add(this.txtbPinCode);
            this.tabAddUpdateFindClient.Controls.Add(this.btnSave);
            this.tabAddUpdateFindClient.Controls.Add(this.label9);
            this.tabAddUpdateFindClient.Controls.Add(this.txtbBalance);
            this.tabAddUpdateFindClient.Controls.Add(this.label8);
            this.tabAddUpdateFindClient.Controls.Add(this.label7);
            this.tabAddUpdateFindClient.Controls.Add(this.label6);
            this.tabAddUpdateFindClient.Controls.Add(this.txtbEmail);
            this.tabAddUpdateFindClient.Controls.Add(this.label5);
            this.tabAddUpdateFindClient.Controls.Add(this.label4);
            this.tabAddUpdateFindClient.Controls.Add(this.txtbLastName);
            this.tabAddUpdateFindClient.Controls.Add(this.label3);
            this.tabAddUpdateFindClient.Controls.Add(this.txtbFirstName);
            this.tabAddUpdateFindClient.Controls.Add(this.lblAddUpdateFindClient);
            this.tabAddUpdateFindClient.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddUpdateFindClient.Location = new System.Drawing.Point(4, 26);
            this.tabAddUpdateFindClient.Name = "tabAddUpdateFindClient";
            this.tabAddUpdateFindClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUpdateFindClient.Size = new System.Drawing.Size(1332, 717);
            this.tabAddUpdateFindClient.TabIndex = 1;
            this.tabAddUpdateFindClient.Text = "AddUpdateFindClient";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 5;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(44, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(216, 55);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "    Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::WinFormForBank.Properties.Resources.IconSearch;
            this.pictureBox3.Location = new System.Drawing.Point(228, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSearch.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblSearch.Location = new System.Drawing.Point(40, 104);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(238, 23);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search By Account No";
            // 
            // txtbSearchClient
            // 
            this.txtbSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbSearchClient.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearchClient.ForeColor = System.Drawing.Color.Black;
            this.txtbSearchClient.Location = new System.Drawing.Point(44, 135);
            this.txtbSearchClient.Multiline = true;
            this.txtbSearchClient.Name = "txtbSearchClient";
            this.txtbSearchClient.Size = new System.Drawing.Size(181, 42);
            this.txtbSearchClient.TabIndex = 24;
            this.txtbSearchClient.TextChanged += new System.EventHandler(this.txtbSearchClient_TextChanged);
            // 
            // txtbPhone
            // 
            this.txtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPhone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPhone.ForeColor = System.Drawing.Color.Black;
            this.txtbPhone.Location = new System.Drawing.Point(780, 415);
            this.txtbPhone.Multiline = true;
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(215, 33);
            this.txtbPhone.TabIndex = 7;
            this.txtbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPhone_KeyPress);
            // 
            // txtbAccNo
            // 
            this.txtbAccNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbAccNo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAccNo.ForeColor = System.Drawing.Color.Black;
            this.txtbAccNo.Location = new System.Drawing.Point(780, 311);
            this.txtbAccNo.Multiline = true;
            this.txtbAccNo.Name = "txtbAccNo";
            this.txtbAccNo.Size = new System.Drawing.Size(215, 33);
            this.txtbAccNo.TabIndex = 6;
            this.txtbAccNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbAccNo_KeyPress);
            // 
            // txtbPinCode
            // 
            this.txtbPinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPinCode.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPinCode.ForeColor = System.Drawing.Color.Black;
            this.txtbPinCode.Location = new System.Drawing.Point(349, 414);
            this.txtbPinCode.Multiline = true;
            this.txtbPinCode.Name = "txtbPinCode";
            this.txtbPinCode.Size = new System.Drawing.Size(215, 33);
            this.txtbPinCode.TabIndex = 3;
            this.txtbPinCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPinCode_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 4;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(780, 487);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 66);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "     Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(780, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Balance";
            // 
            // txtbBalance
            // 
            this.txtbBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbBalance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBalance.ForeColor = System.Drawing.Color.Black;
            this.txtbBalance.Location = new System.Drawing.Point(780, 221);
            this.txtbBalance.Multiline = true;
            this.txtbBalance.Name = "txtbBalance";
            this.txtbBalance.Size = new System.Drawing.Size(215, 33);
            this.txtbBalance.TabIndex = 5;
            this.txtbBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbBalance_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(349, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "PIN Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(777, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Account No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(349, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // txtbEmail
            // 
            this.txtbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmail.ForeColor = System.Drawing.Color.Black;
            this.txtbEmail.Location = new System.Drawing.Point(349, 503);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(215, 25);
            this.txtbEmail.TabIndex = 4;
            this.txtbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtbEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(780, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(349, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // txtbLastName
            // 
            this.txtbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbLastName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLastName.ForeColor = System.Drawing.Color.Black;
            this.txtbLastName.Location = new System.Drawing.Point(349, 315);
            this.txtbLastName.Multiline = true;
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(215, 33);
            this.txtbLastName.TabIndex = 2;
            this.txtbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbLastName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(349, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbFirstName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtbFirstName.Location = new System.Drawing.Point(349, 221);
            this.txtbFirstName.Multiline = true;
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(215, 33);
            this.txtbFirstName.TabIndex = 1;
            this.txtbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFirstName_KeyPress);
            // 
            // lblAddUpdateFindClient
            // 
            this.lblAddUpdateFindClient.AutoSize = true;
            this.lblAddUpdateFindClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddUpdateFindClient.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdateFindClient.ForeColor = System.Drawing.Color.Black;
            this.lblAddUpdateFindClient.Location = new System.Drawing.Point(483, 38);
            this.lblAddUpdateFindClient.Name = "lblAddUpdateFindClient";
            this.lblAddUpdateFindClient.Size = new System.Drawing.Size(344, 46);
            this.lblAddUpdateFindClient.TabIndex = 5;
            this.lblAddUpdateFindClient.Text = "Add New Client";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(345, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1396, 747);
            this.panel2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1753, 771);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabListClients.ResumeLayout(false);
            this.tabListClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabAddUpdateFindClient.ResumeLayout(false);
            this.tabAddUpdateFindClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Button btnListClients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddUpdateFindClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblAddUpdateFindClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.TextBox txtbAccNo;
        private System.Windows.Forms.TextBox txtbPinCode;
        private System.Windows.Forms.TabPage tabListClients;
        private System.Windows.Forms.Label lblNoOfAllClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvListClients;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtbSearchClient;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSearch;
    }
}
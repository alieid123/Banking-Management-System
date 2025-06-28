namespace WinFormForBank
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabListUser = new System.Windows.Forms.TabPage();
            this.lblListAdd = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNoOfAllUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.tabAddUpdateFindUser = new System.Windows.Forms.TabPage();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtSearchByPassword = new System.Windows.Forms.TextBox();
            this.grpbPermissions = new System.Windows.Forms.GroupBox();
            this.chkbCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.chkbManageTransactions = new System.Windows.Forms.CheckBox();
            this.chkbManageUsers = new System.Windows.Forms.CheckBox();
            this.chkbManageClients = new System.Windows.Forms.CheckBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdnYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtbSearchByUser = new System.Windows.Forms.TextBox();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.txtbUserName = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.lblAddUpdateFindUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.tabAddUpdateFindUser.SuspendLayout();
            this.grpbPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.btnListUsers);
            this.panel1.Controls.Add(this.btnAddNewUser);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.btnFindUser);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 721);
            this.panel1.TabIndex = 3;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.White;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.ImageIndex = 3;
            this.btnUpdateUser.ImageList = this.imageList1;
            this.btnUpdateUser.Location = new System.Drawing.Point(8, 499);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(309, 59);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "   Update User";
            this.btnUpdateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
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
            // btnListUsers
            // 
            this.btnListUsers.BackColor = System.Drawing.Color.White;
            this.btnListUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnListUsers.FlatAppearance.BorderSize = 0;
            this.btnListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUsers.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUsers.ImageIndex = 0;
            this.btnListUsers.ImageList = this.imageList1;
            this.btnListUsers.Location = new System.Drawing.Point(8, 321);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(309, 59);
            this.btnListUsers.TabIndex = 1;
            this.btnListUsers.Text = "    Users List ";
            this.btnListUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListUsers.UseVisualStyleBackColor = false;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.White;
            this.btnAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewUser.ImageIndex = 1;
            this.btnAddNewUser.ImageList = this.imageList1;
            this.btnAddNewUser.Location = new System.Drawing.Point(8, 410);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(309, 59);
            this.btnAddNewUser.TabIndex = 2;
            this.btnAddNewUser.Text = "   Add New User";
            this.btnAddNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
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
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.White;
            this.btnFindUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.ImageIndex = 5;
            this.btnFindUser.ImageList = this.imageList1;
            this.btnFindUser.Location = new System.Drawing.Point(8, 588);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(309, 59);
            this.btnFindUser.TabIndex = 4;
            this.btnFindUser.Text = "    Find User";
            this.btnFindUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindUser.UseVisualStyleBackColor = false;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(348, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 767);
            this.panel2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabListUser);
            this.tabControl1.Controls.Add(this.tabAddUpdateFindUser);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1278, 767);
            this.tabControl1.TabIndex = 4;
            // 
            // tabListUser
            // 
            this.tabListUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabListUser.Controls.Add(this.lblListAdd);
            this.tabListUser.Controls.Add(this.label10);
            this.tabListUser.Controls.Add(this.lblNoOfAllUsers);
            this.tabListUser.Controls.Add(this.label1);
            this.tabListUser.Controls.Add(this.pictureBox2);
            this.tabListUser.Controls.Add(this.txtSearch);
            this.tabListUser.Controls.Add(this.dgvListUsers);
            this.tabListUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListUser.Location = new System.Drawing.Point(4, 26);
            this.tabListUser.Name = "tabListUser";
            this.tabListUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabListUser.Size = new System.Drawing.Size(1270, 737);
            this.tabListUser.TabIndex = 0;
            this.tabListUser.Text = "User List";
            // 
            // lblListAdd
            // 
            this.lblListAdd.AutoSize = true;
            this.lblListAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblListAdd.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListAdd.ForeColor = System.Drawing.Color.Black;
            this.lblListAdd.Location = new System.Drawing.Point(513, 32);
            this.lblListAdd.Name = "lblListAdd";
            this.lblListAdd.Size = new System.Drawing.Size(220, 46);
            this.lblListAdd.TabIndex = 7;
            this.lblListAdd.Text = "Users List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(970, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Search By UserName";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblNoOfAllUsers
            // 
            this.lblNoOfAllUsers.AutoSize = true;
            this.lblNoOfAllUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNoOfAllUsers.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfAllUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblNoOfAllUsers.Location = new System.Drawing.Point(19, 103);
            this.lblNoOfAllUsers.Name = "lblNoOfAllUsers";
            this.lblNoOfAllUsers.Size = new System.Drawing.Size(0, 32);
            this.lblNoOfAllUsers.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(964, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WinFormForBank.Properties.Resources.IconSearch;
            this.pictureBox2.Location = new System.Drawing.Point(1214, 115);
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
            this.txtSearch.Location = new System.Drawing.Point(968, 115);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.AllowUserToAddRows = false;
            this.dgvListUsers.AllowUserToDeleteRows = false;
            this.dgvListUsers.AllowUserToOrderColumns = true;
            this.dgvListUsers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListUsers.EnableHeadersVisualStyles = false;
            this.dgvListUsers.Location = new System.Drawing.Point(16, 182);
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.ReadOnly = true;
            this.dgvListUsers.RowHeadersWidth = 51;
            this.dgvListUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dgvListUsers.RowTemplate.Height = 24;
            this.dgvListUsers.Size = new System.Drawing.Size(1251, 549);
            this.dgvListUsers.TabIndex = 0;
            this.dgvListUsers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListUsers_DataBindingComplete);
            // 
            // tabAddUpdateFindUser
            // 
            this.tabAddUpdateFindUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAddUpdateFindUser.Controls.Add(this.lblPassword);
            this.tabAddUpdateFindUser.Controls.Add(this.txtSearchByPassword);
            this.tabAddUpdateFindUser.Controls.Add(this.grpbPermissions);
            this.tabAddUpdateFindUser.Controls.Add(this.btnSearch);
            this.tabAddUpdateFindUser.Controls.Add(this.lblUserName);
            this.tabAddUpdateFindUser.Controls.Add(this.txtbSearchByUser);
            this.tabAddUpdateFindUser.Controls.Add(this.txtbPhone);
            this.tabAddUpdateFindUser.Controls.Add(this.txtbUserName);
            this.tabAddUpdateFindUser.Controls.Add(this.txtbPassword);
            this.tabAddUpdateFindUser.Controls.Add(this.btnSave);
            this.tabAddUpdateFindUser.Controls.Add(this.label8);
            this.tabAddUpdateFindUser.Controls.Add(this.label7);
            this.tabAddUpdateFindUser.Controls.Add(this.label6);
            this.tabAddUpdateFindUser.Controls.Add(this.txtbEmail);
            this.tabAddUpdateFindUser.Controls.Add(this.label5);
            this.tabAddUpdateFindUser.Controls.Add(this.label4);
            this.tabAddUpdateFindUser.Controls.Add(this.txtbLastName);
            this.tabAddUpdateFindUser.Controls.Add(this.label3);
            this.tabAddUpdateFindUser.Controls.Add(this.txtbFirstName);
            this.tabAddUpdateFindUser.Controls.Add(this.lblAddUpdateFindUser);
            this.tabAddUpdateFindUser.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddUpdateFindUser.Location = new System.Drawing.Point(4, 26);
            this.tabAddUpdateFindUser.Name = "tabAddUpdateFindUser";
            this.tabAddUpdateFindUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUpdateFindUser.Size = new System.Drawing.Size(1270, 737);
            this.tabAddUpdateFindUser.TabIndex = 1;
            this.tabAddUpdateFindUser.Text = "AddUpdateFindUser";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPassword.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblPassword.Location = new System.Drawing.Point(221, 38);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 23);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password";
            // 
            // txtSearchByPassword
            // 
            this.txtSearchByPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchByPassword.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPassword.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByPassword.Location = new System.Drawing.Point(222, 69);
            this.txtSearchByPassword.Multiline = true;
            this.txtSearchByPassword.Name = "txtSearchByPassword";
            this.txtSearchByPassword.Size = new System.Drawing.Size(181, 35);
            this.txtSearchByPassword.TabIndex = 29;
            // 
            // grpbPermissions
            // 
            this.grpbPermissions.Controls.Add(this.chkbCurrencyExchange);
            this.grpbPermissions.Controls.Add(this.chkbManageTransactions);
            this.grpbPermissions.Controls.Add(this.chkbManageUsers);
            this.grpbPermissions.Controls.Add(this.chkbManageClients);
            this.grpbPermissions.Controls.Add(this.rdbNo);
            this.grpbPermissions.Controls.Add(this.rdnYes);
            this.grpbPermissions.Controls.Add(this.label2);
            this.grpbPermissions.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.grpbPermissions.Location = new System.Drawing.Point(392, 480);
            this.grpbPermissions.Name = "grpbPermissions";
            this.grpbPermissions.Size = new System.Drawing.Size(600, 207);
            this.grpbPermissions.TabIndex = 27;
            this.grpbPermissions.TabStop = false;
            this.grpbPermissions.Text = "Permissions";
            // 
            // chkbCurrencyExchange
            // 
            this.chkbCurrencyExchange.AutoSize = true;
            this.chkbCurrencyExchange.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbCurrencyExchange.Location = new System.Drawing.Point(342, 144);
            this.chkbCurrencyExchange.Name = "chkbCurrencyExchange";
            this.chkbCurrencyExchange.Size = new System.Drawing.Size(210, 25);
            this.chkbCurrencyExchange.TabIndex = 34;
            this.chkbCurrencyExchange.Tag = "8";
            this.chkbCurrencyExchange.Text = "Currency Exchange";
            this.chkbCurrencyExchange.UseVisualStyleBackColor = true;
            // 
            // chkbManageTransactions
            // 
            this.chkbManageTransactions.AutoSize = true;
            this.chkbManageTransactions.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbManageTransactions.Location = new System.Drawing.Point(342, 105);
            this.chkbManageTransactions.Name = "chkbManageTransactions";
            this.chkbManageTransactions.Size = new System.Drawing.Size(224, 25);
            this.chkbManageTransactions.TabIndex = 33;
            this.chkbManageTransactions.Tag = "2";
            this.chkbManageTransactions.Text = "Manage Transactions";
            this.chkbManageTransactions.UseVisualStyleBackColor = true;
            // 
            // chkbManageUsers
            // 
            this.chkbManageUsers.AutoSize = true;
            this.chkbManageUsers.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbManageUsers.Location = new System.Drawing.Point(16, 144);
            this.chkbManageUsers.Name = "chkbManageUsers";
            this.chkbManageUsers.Size = new System.Drawing.Size(158, 25);
            this.chkbManageUsers.TabIndex = 32;
            this.chkbManageUsers.Tag = "4";
            this.chkbManageUsers.Text = "Manage Users";
            this.chkbManageUsers.UseVisualStyleBackColor = true;
            // 
            // chkbManageClients
            // 
            this.chkbManageClients.AutoSize = true;
            this.chkbManageClients.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbManageClients.Location = new System.Drawing.Point(16, 105);
            this.chkbManageClients.Name = "chkbManageClients";
            this.chkbManageClients.Size = new System.Drawing.Size(170, 25);
            this.chkbManageClients.TabIndex = 31;
            this.chkbManageClients.Tag = "1";
            this.chkbManageClients.Text = "Manage Clinets";
            this.chkbManageClients.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(308, 56);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(60, 27);
            this.rdbNo.TabIndex = 30;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // rdnYes
            // 
            this.rdnYes.AutoSize = true;
            this.rdnYes.Location = new System.Drawing.Point(203, 56);
            this.rdnYes.Name = "rdnYes";
            this.rdnYes.Size = new System.Drawing.Size(68, 27);
            this.rdnYes.TabIndex = 29;
            this.rdnYes.TabStop = true;
            this.rdnYes.Text = "Yes";
            this.rdnYes.UseVisualStyleBackColor = true;
            this.rdnYes.CheckedChanged += new System.EventHandler(this.rdnYes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(199, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Give Full Access?";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSearch.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 5;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(110, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(234, 55);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "    Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lblUserName.Location = new System.Drawing.Point(18, 38);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(121, 23);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "UserName ";
            // 
            // txtbSearchByUser
            // 
            this.txtbSearchByUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbSearchByUser.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearchByUser.ForeColor = System.Drawing.Color.Black;
            this.txtbSearchByUser.Location = new System.Drawing.Point(21, 69);
            this.txtbSearchByUser.Multiline = true;
            this.txtbSearchByUser.Name = "txtbSearchByUser";
            this.txtbSearchByUser.Size = new System.Drawing.Size(181, 33);
            this.txtbSearchByUser.TabIndex = 24;
            // 
            // txtbPhone
            // 
            this.txtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPhone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPhone.ForeColor = System.Drawing.Color.Black;
            this.txtbPhone.Location = new System.Drawing.Point(761, 238);
            this.txtbPhone.Multiline = true;
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(215, 33);
            this.txtbPhone.TabIndex = 7;
            this.txtbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPhone_KeyPress);
            // 
            // txtbUserName
            // 
            this.txtbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUserName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUserName.ForeColor = System.Drawing.Color.Black;
            this.txtbUserName.Location = new System.Drawing.Point(405, 238);
            this.txtbUserName.Multiline = true;
            this.txtbUserName.Name = "txtbUserName";
            this.txtbUserName.Size = new System.Drawing.Size(215, 33);
            this.txtbUserName.TabIndex = 6;
            // 
            // txtbPassword
            // 
            this.txtbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.ForeColor = System.Drawing.Color.Black;
            this.txtbPassword.Location = new System.Drawing.Point(761, 417);
            this.txtbPassword.Multiline = true;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(215, 33);
            this.txtbPassword.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 4;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(1018, 621);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 66);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "     Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(761, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(405, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "UserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(761, 302);
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
            this.txtbEmail.Location = new System.Drawing.Point(761, 328);
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
            this.label5.Location = new System.Drawing.Point(761, 211);
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
            this.label4.Location = new System.Drawing.Point(405, 390);
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
            this.txtbLastName.Location = new System.Drawing.Point(405, 418);
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
            this.label3.Location = new System.Drawing.Point(405, 300);
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
            this.txtbFirstName.Location = new System.Drawing.Point(405, 328);
            this.txtbFirstName.Multiline = true;
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(215, 33);
            this.txtbFirstName.TabIndex = 1;
            this.txtbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFirstName_KeyPress);
            // 
            // lblAddUpdateFindUser
            // 
            this.lblAddUpdateFindUser.AutoSize = true;
            this.lblAddUpdateFindUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddUpdateFindUser.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdateFindUser.ForeColor = System.Drawing.Color.Black;
            this.lblAddUpdateFindUser.Location = new System.Drawing.Point(525, 38);
            this.lblAddUpdateFindUser.Name = "lblAddUpdateFindUser";
            this.lblAddUpdateFindUser.Size = new System.Drawing.Size(313, 46);
            this.lblAddUpdateFindUser.TabIndex = 5;
            this.lblAddUpdateFindUser.Text = "Add New User";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1795, 771);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabListUser.ResumeLayout(false);
            this.tabListUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.tabAddUpdateFindUser.ResumeLayout(false);
            this.tabAddUpdateFindUser.PerformLayout();
            this.grpbPermissions.ResumeLayout(false);
            this.grpbPermissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabListUser;
        private System.Windows.Forms.Label lblListAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNoOfAllUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.TabPage tabAddUpdateFindUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtbSearchByUser;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.TextBox txtbUserName;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.Label lblAddUpdateFindUser;
        private System.Windows.Forms.GroupBox grpbPermissions;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdnYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbManageTransactions;
        private System.Windows.Forms.CheckBox chkbManageUsers;
        private System.Windows.Forms.CheckBox chkbManageClients;
        private System.Windows.Forms.CheckBox chkbCurrencyExchange;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtSearchByPassword;
    }
}
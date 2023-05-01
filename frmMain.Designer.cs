namespace My_Password
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnPassGene = new System.Windows.Forms.Button();
            this.btnPassID = new System.Windows.Forms.Button();
            this.lblYouHave = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassID = new System.Windows.Forms.Label();
            this.txtPassID = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.PassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTop);
            this.pnlTop.Controls.Add(this.button2);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 36);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTop.ForeColor = System.Drawing.Color.White;
            this.lblTop.Location = new System.Drawing.Point(393, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblTop.Size = new System.Drawing.Size(164, 36);
            this.lblTop.TabIndex = 3;
            this.lblTop.Text = "Passwords";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(842, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(878, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(914, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnShowPass);
            this.pnlButton.Controls.Add(this.btnPassGene);
            this.pnlButton.Controls.Add(this.btnPassID);
            this.pnlButton.Controls.Add(this.lblYouHave);
            this.pnlButton.Controls.Add(this.lblDescription);
            this.pnlButton.Controls.Add(this.txtDescription);
            this.pnlButton.Controls.Add(this.lblPassword);
            this.pnlButton.Controls.Add(this.txtPassword);
            this.pnlButton.Controls.Add(this.lblTittle);
            this.pnlButton.Controls.Add(this.txtTittle);
            this.pnlButton.Controls.Add(this.lblUsername);
            this.pnlButton.Controls.Add(this.txtUsername);
            this.pnlButton.Controls.Add(this.lblPassID);
            this.pnlButton.Controls.Add(this.txtPassID);
            this.pnlButton.Controls.Add(this.lblSearch);
            this.pnlButton.Controls.Add(this.txtSearch);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnCancle);
            this.pnlButton.Controls.Add(this.btnSearch);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 331);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(950, 332);
            this.pnlButton.TabIndex = 1;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.btnShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPass.BackgroundImage")));
            this.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Location = new System.Drawing.Point(825, 162);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(36, 25);
            this.btnShowPass.TabIndex = 20;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnPassGene
            // 
            this.btnPassGene.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassGene.BackgroundImage")));
            this.btnPassGene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPassGene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassGene.FlatAppearance.BorderSize = 0;
            this.btnPassGene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassGene.Location = new System.Drawing.Point(878, 164);
            this.btnPassGene.Name = "btnPassGene";
            this.btnPassGene.Size = new System.Drawing.Size(27, 27);
            this.btnPassGene.TabIndex = 19;
            this.btnPassGene.UseVisualStyleBackColor = true;
            this.btnPassGene.Click += new System.EventHandler(this.btnPassGene_Click);
            // 
            // btnPassID
            // 
            this.btnPassID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassID.BackgroundImage")));
            this.btnPassID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPassID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassID.FlatAppearance.BorderSize = 0;
            this.btnPassID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassID.Location = new System.Drawing.Point(312, 125);
            this.btnPassID.Name = "btnPassID";
            this.btnPassID.Size = new System.Drawing.Size(27, 27);
            this.btnPassID.TabIndex = 18;
            this.btnPassID.UseVisualStyleBackColor = true;
            this.btnPassID.Click += new System.EventHandler(this.btnPassID_Click);
            // 
            // lblYouHave
            // 
            this.lblYouHave.AutoSize = true;
            this.lblYouHave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYouHave.Location = new System.Drawing.Point(143, 293);
            this.lblYouHave.Name = "lblYouHave";
            this.lblYouHave.Size = new System.Drawing.Size(127, 24);
            this.lblYouHave.TabIndex = 17;
            this.lblYouHave.Text = "You have ...";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(16, 205);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 24);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtDescription.Location = new System.Drawing.Point(147, 203);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(767, 72);
            this.txtDescription.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(460, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 24);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtPassword.Location = new System.Drawing.Point(568, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 36);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTittle.Location = new System.Drawing.Point(460, 125);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(62, 24);
            this.lblTittle.TabIndex = 12;
            this.lblTittle.Text = "Tittle";
            // 
            // txtTittle
            // 
            this.txtTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.txtTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtTittle.Location = new System.Drawing.Point(568, 119);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(293, 36);
            this.txtTittle.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(16, 167);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(112, 24);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtUsername.Location = new System.Drawing.Point(147, 161);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(296, 36);
            this.txtUsername.TabIndex = 9;
            // 
            // lblPassID
            // 
            this.lblPassID.AutoSize = true;
            this.lblPassID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassID.Location = new System.Drawing.Point(16, 125);
            this.lblPassID.Name = "lblPassID";
            this.lblPassID.Size = new System.Drawing.Size(80, 24);
            this.lblPassID.TabIndex = 8;
            this.lblPassID.Text = "PassID";
            // 
            // txtPassID
            // 
            this.txtPassID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.txtPassID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtPassID.Location = new System.Drawing.Point(147, 119);
            this.txtPassID.Name = "txtPassID";
            this.txtPassID.ReadOnly = true;
            this.txtPassID.Size = new System.Drawing.Size(147, 36);
            this.txtPassID.TabIndex = 7;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(460, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 24);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtSearch.Location = new System.Drawing.Point(568, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 36);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(668, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancle.Location = new System.Drawing.Point(794, 281);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(120, 36);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(744, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(147, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(21, 17);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 36);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.AllowUserToAddRows = false;
            this.dgvDatabase.AllowUserToDeleteRows = false;
            this.dgvDatabase.AllowUserToResizeColumns = false;
            this.dgvDatabase.AllowUserToResizeRows = false;
            this.dgvDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatabase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.dgvDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatabase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatabase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatabase.ColumnHeadersHeight = 34;
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatabase.ColumnHeadersVisible = false;
            this.dgvDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassID,
            this.Title,
            this.Username,
            this.Password,
            this.Description});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(208)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatabase.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabase.EnableHeadersVisualStyles = false;
            this.dgvDatabase.Location = new System.Drawing.Point(0, 36);
            this.dgvDatabase.MultiSelect = false;
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.ReadOnly = true;
            this.dgvDatabase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatabase.RowHeadersVisible = false;
            this.dgvDatabase.RowHeadersWidth = 62;
            this.dgvDatabase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatabase.RowTemplate.Height = 36;
            this.dgvDatabase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabase.Size = new System.Drawing.Size(950, 295);
            this.dgvDatabase.TabIndex = 2;
            this.dgvDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatabase_CellClick);
            this.dgvDatabase.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDatabase_CellFormatting);
            // 
            // PassID
            // 
            this.PassID.HeaderText = "PassID";
            this.PassID.MinimumWidth = 8;
            this.PassID.Name = "PassID";
            this.PassID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(950, 663);
            this.Controls.Add(this.dgvDatabase);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My_Password";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnPassGene;
        private System.Windows.Forms.Button btnPassID;
        private System.Windows.Forms.Label lblYouHave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.TextBox txtTittle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassID;
        private System.Windows.Forms.TextBox txtPassID;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}


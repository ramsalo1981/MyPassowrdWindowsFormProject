namespace My_Password
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.pbpass = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTop);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(500, 36);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(464, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTop
            // 
            this.lblTop.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTop.ForeColor = System.Drawing.Color.White;
            this.lblTop.Location = new System.Drawing.Point(168, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblTop.Size = new System.Drawing.Size(164, 36);
            this.lblTop.TabIndex = 6;
            this.lblTop.Text = "Passwords";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(12, 67);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(112, 24);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.Red;
            this.txtUsername.Location = new System.Drawing.Point(143, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(285, 36);
            this.txtUsername.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(17, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 24);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(143, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(285, 36);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnLogin);
            this.pnlBottom.Controls.Add(this.btnCancle);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 200);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(500, 50);
            this.pnlBottom.TabIndex = 17;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(143, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancle.Location = new System.Drawing.Point(308, 3);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(120, 36);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogin.BackgroundImage")));
            this.pbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogin.Location = new System.Drawing.Point(428, 61);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(36, 30);
            this.pbLogin.TabIndex = 18;
            this.pbLogin.TabStop = false;
            // 
            // pbpass
            // 
            this.pbpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbpass.BackgroundImage")));
            this.pbpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbpass.Location = new System.Drawing.Point(428, 109);
            this.pbpass.Name = "pbpass";
            this.pbpass.Size = new System.Drawing.Size(36, 26);
            this.pbpass.TabIndex = 19;
            this.pbpass.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.pbpass);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pbpass;
    }
}
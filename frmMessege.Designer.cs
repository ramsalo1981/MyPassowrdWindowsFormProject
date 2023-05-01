namespace My_Password
{
    partial class frmMessege
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lblMessege = new System.Windows.Forms.Label();
            this.tmrMessege = new System.Windows.Forms.Timer(this.components);
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(500, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlButtom
            // 
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 200);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(500, 50);
            this.pnlButtom.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.pnlCenter.Controls.Add(this.lblMessege);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 50);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(500, 150);
            this.pnlCenter.TabIndex = 2;
            // 
            // lblMessege
            // 
            this.lblMessege.AutoSize = true;
            this.lblMessege.Location = new System.Drawing.Point(193, 61);
            this.lblMessege.Name = "lblMessege";
            this.lblMessege.Size = new System.Drawing.Size(115, 29);
            this.lblMessege.TabIndex = 0;
            this.lblMessege.Text = "Messege";
            // 
            // tmrMessege
            // 
            this.tmrMessege.Enabled = true;
            this.tmrMessege.Interval = 5000;
            this.tmrMessege.Tick += new System.EventHandler(this.tmrMessege_Tick);
            // 
            // frmMessege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMessege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessege";
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lblMessege;
        private System.Windows.Forms.Timer tmrMessege;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Password
{
    public partial class frmLogin : Form
    {
        int movx, movy, move;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

       

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X; movy = e.Y;
        }

        

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y -movy);
            }
        }

        

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
                {
                    Form frmMessegeEmpty = new frmMessege("Username or Password is empty!!");
                    frmMessegeEmpty.ShowDialog();
                }
                else
                {
                    if (txtUsername.Text == "Admin" && txtPassword.Text == "123123")
                    {
                        Form frmMessegeCorrect = new frmMessege("Welcome to APP!!!");
                        frmMessegeCorrect.ShowDialog();
                        //this.Close();
                        this.Hide();
                        Form fMain = new frmMain();
                        fMain.Show();
                    }
                    else
                    {
                        Form frmMessegeWrong = new frmMessege("Username or Password is NotCorrect!!");
                        frmMessegeWrong.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error!\n {ex}");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar( Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}

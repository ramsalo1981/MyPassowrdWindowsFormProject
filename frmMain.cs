using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Password
{
    public partial class frmMain : Form
    {
        int movx, movy, move;
        string databasePath = Application.StartupPath + @"\Database.txt";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }



        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists(databasePath))
            {
                File.Create(databasePath).Close();
            }

            FillDataGridView(databasePath, dgvDatabase);

            lblYouHave.Text= PasswordCount(dgvDatabase);

            //Form startForm = new frmLogin();
            //startForm.ShowDialog();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sPassID = txtPassID.Text;
                string sTitle = txtTittle.Text;
                string sUsername = txtUsername.Text;
                string sPassword = txtPassword.Text;
                string sDesc = txtDescription.Text;

                bool passIdStatus = true;

                if (string.IsNullOrEmpty(sPassID) || string.IsNullOrEmpty(sUsername) || string.IsNullOrEmpty(sPassword))
                {
                    Form frmError = new frmMessege("Error!!!\nUsername or Password is empty");
                    frmError.ShowDialog();
                }
                else
                {
                    StreamReader sr = new StreamReader(databasePath);
                    string line;
                    do
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            string[] sLine = line.Split(';');
                            if (sLine[0] == txtPassID.Text)
                            {
                                passIdStatus = false;
                            }
                        }
                    } while (line != null);
                    sr.Close();

                    if (passIdStatus)
                    {
                        StreamWriter sw = new StreamWriter(databasePath, true);
                        sw.WriteLine($"{sPassID};{sTitle};{sUsername};{sPassword};{sDesc}");
                        sw.Close();

                        txtPassID.Clear();
                        txtTittle.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtDescription.Clear();
                    }
                    else
                    {
                        Form frmError = new frmMessege("Error!!!\nThis PassId is already exist.");
                        frmError.ShowDialog();
                    }
                }

                lblYouHave.Text = PasswordCount(dgvDatabase);
                FillDataGridView(databasePath, dgvDatabase);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error!!!\n{ex}");
            }


        }
        private void btnPassID_Click(object sender, EventArgs e)
        {
            txtPassID.Text = PassID_Generator(databasePath);
        }

        private void btnPassGene_Click(object sender, EventArgs e)
        {
            txtPassword.Text = Password_Generator();
        }

        

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtPassword.Clear();
            txtTittle.Clear();
            txtDescription.Clear();
            txtUsername.Clear();
            txtPassID.Clear();


            txtPassID.Text = PassID_Generator(databasePath);
            txtUsername.Focus();

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtPassword.Clear();
            txtTittle.Clear();
            txtDescription.Clear();
            txtUsername.Clear();
            txtPassID.Clear();
        }

        private void dgvDatabase_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void dgvDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPassID.Text = dgvDatabase.CurrentRow.Cells[0].Value.ToString();
            txtTittle.Text = dgvDatabase.CurrentRow.Cells[1].Value.ToString();
            txtUsername.Text = dgvDatabase.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text = dgvDatabase.CurrentRow.Cells[3].Value.ToString();
            txtDescription.Text = dgvDatabase.CurrentRow.Cells[4].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string passIdDel = dgvDatabase.CurrentRow.Cells[0].Value.ToString();
            string tempFile = Path.GetTempFileName();
            //MessageBox.Show(tempFile);

            using (var sr = new StreamReader(databasePath))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dataLine = line.Split(';');
                    if (dataLine[0] != passIdDel)
                    {
                        sw.WriteLine(line);
                    }
                }
            }

            File.Delete(databasePath);
            File.Move(tempFile, databasePath);



            FillDataGridView(databasePath, dgvDatabase);

            lblYouHave.Text = PasswordCount(dgvDatabase);

            txtSearch.Clear();
            txtPassword.Clear();
            txtTittle.Clear();
            txtDescription.Clear();
            txtUsername.Clear();
            txtPassID.Clear();

            Form frmdel = new frmMessege("Delete Data");
            frmdel.ShowDialog();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                StreamReader sr = new StreamReader(databasePath);
                dgvDatabase.Rows.Clear();
                dgvDatabase.Refresh();
                string line;
                bool found = false;
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] dataLine = line.Split(';');
                        if (dataLine.Contains(txtSearch.Text))
                        {
                            dgvDatabase.Rows.Add(dataLine);
                            found = true;
                        }
                    }
                } while (line != null);
                sr.Close();

                lblYouHave.Text = PasswordCount(dgvDatabase);

                if (found == false)
                {
                    Form fNotFound = new frmMessege("Not found!!!");
                    fNotFound.ShowDialog();
                }
                else
                {
                   int i= dgvDatabase.Rows.Count;
                    Form fCount = new frmMessege($"{i} Result!!");
                    fCount.ShowDialog();
                }
            }
            else
            {
                FillDataGridView(databasePath, dgvDatabase);
                lblYouHave.Text = PasswordCount(dgvDatabase);

            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                FillDataGridView(databasePath,dgvDatabase);

                lblYouHave.Text = PasswordCount(dgvDatabase);

            }
        }



        //Import Data to dgvDatabase
        public static void FillDataGridView(string DatabasePath, DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                StreamReader reDatabase = new StreamReader(DatabasePath);
                string reLine;
                do
                {
                    reLine = reDatabase.ReadLine();
                    if (reLine != null)
                    {
                        object[] dataline = reLine.Split(';');
                        dataGridView.Rows.Add(dataline);
                    }
                } while (reLine != null);

                reDatabase.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error!!\n {ex}");
            }

        }

        //PassId Generatot
        public static string PassID_Generator(string path)
        {
            try
            {
                StreamReader reDatabase = new StreamReader(path);
                string reLine;
                int i = 1;
                do
                {
                    reLine = reDatabase.ReadLine();
                    if (reLine != null)
                    {
                        string[] reDataLine = reLine.Split(';');
                        string passIdStr = reDataLine[0].Substring(1);
                        int passId = Convert.ToInt32(passIdStr);
                        if (i <= passId)
                        {
                            i = passId + 1;
                        }

                    }
                } while (reLine != null);
                reDatabase.Close();

                return $"p0{i}";
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error!!!\n {ex}");
                return "Error";
            }

        }
        //Password generator
        public static string Password_Generator()
        {
            try
            {
                const string valId = "abcdefghijklmnopqrstuwvxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
                string myPass = "";
                Random rnd = new Random();

                for (int i = 1; i < 8; i++)
                {
                    int val = rnd.Next(valId.Length);
                    myPass += valId[val];
                }
                return myPass;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error!!\n{ex}");
                return "ERROR!!";
            }
        }

        //count number of password
        public static string PasswordCount(DataGridView dgv)
        {
            int i =dgv.Rows.Count;
            return ($"You have {i} passwords");
        }
    }
}

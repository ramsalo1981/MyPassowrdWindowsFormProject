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
    public partial class frmMessege : Form
    {
        public frmMessege(string messege)
        {
            InitializeComponent();
            lblMessege.Text = messege;
            lblMessege.Location = new Point((this.Width - lblMessege.Width) / 2, 61);
        }

        private void tmrMessege_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

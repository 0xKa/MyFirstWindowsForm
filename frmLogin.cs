using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblMessage.Text = string.Empty;
            lblMessage.Visible = false;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
            if (txtUsername.TextLength == 0)
            {
                lblMessage.Text = "Please Enter Username and Password!!!";
                lblMessage.Location = new Point(195, 360);
            }
            else
            {
                lblMessage.Text = txtUsername.Text + " Logged In.";
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;

                Form form = new frmMain(txtUsername.Text); //show next form if login success
                form.ShowDialog();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblShowPassword.Visible)
                lblShowPassword.Visible = false;
            else
                lblShowPassword.Visible = true;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblShowPassword.Text = txtPassword.Text;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Username & Password to Login to the Calculator", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

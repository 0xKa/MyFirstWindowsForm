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
    public partial class frmMain : Form
    {
        public frmMain(string Username)
        {
            InitializeComponent();
            lblWelcome.Text += " " + Username + ".";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Form form = new frmFeedback();
            form.ShowDialog();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            double Result = Convert.ToDouble(txtNumber1.Text) - Convert.ToDouble(txtNumber2.Text);
            txtResult.Text = Result.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double Result = Convert.ToDouble(txtNumber1.Text) + Convert.ToDouble(txtNumber2.Text);
            txtResult.Text = Result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double Result = Convert.ToDouble(txtNumber1.Text) * Convert.ToDouble(txtNumber2.Text);
            txtResult.Text = Result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double Result = Convert.ToDouble(txtNumber1.Text) / Convert.ToDouble(txtNumber2.Text);
            txtResult.Text = Result.ToString();
        }
    }
}

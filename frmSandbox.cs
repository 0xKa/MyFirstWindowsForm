using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class frmSandbox : Form
    {
        public frmSandbox()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form form = new frmLogin();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Focus();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!maskedTextBox1.MaskFull) //textbox not filled
            {
                maskedTextBox1.Text = string.Empty;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox9.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
                comboBox1.Items.RemoveAt(0);//
        }

        private void frmSandbox_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true; //change link color
            System.Diagnostics.Process.Start("https://www.google.com/"); //open link in default browser
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox10.Text.Length <= 0) return;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if ((checkedListBox1.Items[i].ToString() == textBox10.Text))
                    return;
            }
            
            checkedListBox1.Items.Add(textBox10.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox11.Text.Length <= 0) return;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if ((checkedListBox1.Items[i].ToString() == textBox11.Text))
                {
                    checkedListBox1.Items.RemoveAt(i);
                    return;
                }
            }
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString() + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd/MM/yy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd-MMM--yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd, dd,MMMM,yyyy") + Environment.NewLine;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string StartDate = monthCalendar1.SelectionRange.Start.ToString();
            MessageBox.Show(StartDate);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string EndDate = monthCalendar1.SelectionRange.End.ToString();
            MessageBox.Show(EndDate);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string FullRange = monthCalendar1.SelectionRange.ToString();
            MessageBox.Show(FullRange);

        }
    }
}

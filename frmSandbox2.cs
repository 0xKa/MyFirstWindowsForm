using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class frmSandbox2 : Form
    {
        public frmSandbox2()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form form = new frmLogin();
            form.Show();
        }

        private int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();

        }

        private void frmSandbox2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //or
            //timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = Icon.ExtractAssociatedIcon(@"F:\ProgrammingAdvices\Course 14 - C# lvl1\images\star_planet_icon_263076.ico");
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "TITLE";
            notifyIcon1.BalloonTipText = "TEXTTTTTTTTTTTT";

            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            button3.Text = "you clicked";
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.ToString());
        }

        private void CheckTreeViewNode(TreeNode node, bool isChecked)
        {
            foreach(TreeNode item in node.Nodes)
            {
                item.Checked = isChecked; //check each item
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked); //if node checked, childs will be checked
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label2.Text = treeView1.SelectedNode.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (progressBar1.Value < progressBar1.Maximum)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500); //pause program

                    progressBar1.Value += 10;
                    label3.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";

                    progressBar1.Refresh(); //resume the pasue
                    label3.Refresh();
                }
            }

            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label3.Text = "0%";

            button4.Enabled = true;
            button5.Enabled = false;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true; //can't leave the textBox
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Thix TextBox Cannot be empty");
            }
            else
            {
                e.Cancel = false; //can leave the textBox
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = numericUpDown1.Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) //when user click OK
                textBox4.BackColor = colorDialog1.Color;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) //when user click OK
                textBox4.ForeColor = colorDialog1.Color;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowHelp = true;


            fontDialog1.Font = textBox4.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Font = fontDialog1.Font;
                textBox4.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox4.Font = fontDialog1.Font;
            textBox4.ForeColor = fontDialog1.Color;
        }

        private void fontDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a Font for the Text in textBox4");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"F:\"; //can choose what will be showen-> C:, F:, etc
            saveFileDialog1.Title = "XYXYXYXYXYXY";
            saveFileDialog1.DefaultExt = "txt";//defualt extention

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt | All files (*.*)|*.* | GGGGGGGGGGG (*.GG)|*.GG"; //Save as a Type Menu
            saveFileDialog1.FilterIndex = 2; //defualt filter

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //same properties as saveFileDialog

            openFileDialog1.InitialDirectory = @"F:\";
            openFileDialog1.Title = "OPEN FILE";
            openFileDialog1.DefaultExt = "txt";

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName); 
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Multi Select Open File Dialog
            openFileDialog1.Multiselect = true;

            openFileDialog1.InitialDirectory = @"F:\";
            openFileDialog1.Title = "OPEN MULTIPLE FILES";
            openFileDialog1.DefaultExt = "txt";

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string AllSelectedFiles = "";
                foreach (string file in openFileDialog1.FileNames)
                {
                    AllSelectedFiles += file + " - ";
                }
                    MessageBox.Show(AllSelectedFiles);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}

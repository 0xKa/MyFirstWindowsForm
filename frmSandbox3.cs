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
    public partial class frmSandbox3 : Form
    {
        public frmSandbox3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;

            ListViewItem item = new ListViewItem(txtID.Text.Trim().ToLower());
            if (rbFemale.Checked )
                item.ImageIndex = 1;
            else 
                item.ImageIndex = 0;

            item.SubItems.Add(txtName.Text.Trim());
            item.SubItems.Add(txtAge.Text.Trim());
            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtAge.Clear();

            txtID.Focus();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTiles_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            bool isMale = true;

            for(int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem();

                item.Text = i.ToString();
                item.ImageIndex = Convert.ToInt32(isMale);
                item.SubItems.Add( "Person" + i.ToString());

                listView1.Items.Add( item );

                isMale = !isMale;
            }

        }
    }
}

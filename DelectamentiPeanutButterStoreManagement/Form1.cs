using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelectamentiPeanutButterStoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenSelectedBranch(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            string selectedItem = item.SubItems[1].Text;

            // open the table with the name of the selectedItem
        }
    }
}

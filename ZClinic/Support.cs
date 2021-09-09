using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZClinic
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
            panel1.Show();
            panel2.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            string itemText = e.ClickedItem.Text;
            if (itemText == "User")
            {
                panel1.Show();
            }
            if (itemText == "IT")
            {
                panel2.Show();
            }
        }
    }
}
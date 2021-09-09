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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            string itemText = e.ClickedItem.Text;
            if (itemText == "Preserve")
            {
                panel1.Show();
            }
            if (itemText == "Add")
            {
                panel2.Show();
            }
            if (itemText == "All")
            {
                panel3.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
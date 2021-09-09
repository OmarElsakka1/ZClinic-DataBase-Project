using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZClinic
{
    public partial class Comment : UserControl
    {

        public string Commentss { get; set; }
        public Comment()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            //this.Enabled = false;
            textBox1.Text = Commentss;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            //textBox1.Select(textBox1.Text.Length, 0);
            //PositionCursor.Select(PositionCursor.Text.Length, 0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            SupportUser.Instance.RemoveMed(this);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //this.Enabled = true;
            textBox1.ReadOnly = true;
        }

        private void Comment_ControlRemoved(object sender, ControlEventArgs e)
        {

        }
    }
}
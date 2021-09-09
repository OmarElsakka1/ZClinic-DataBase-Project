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
    public partial class RevisedComments : UserControl
    {
        public Image RevisedCommentsImage { get; set; }
        public string RevisedCommentsName { get; set; }
        public string RevisedCommentsEmail { get; set; }
        public string RevisedCommentsComment { get; set; }
        public RevisedComments()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void RevisedComments_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = RevisedCommentsImage;
            bunifuCustomLabel2.Text = RevisedCommentsName;
            bunifuCustomLabel3.Text = RevisedCommentsEmail;
            textBox1.Text = RevisedCommentsComment;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SupportIT.Instance.AddAgain(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
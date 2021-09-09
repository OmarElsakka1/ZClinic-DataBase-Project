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
    public partial class ShowingComment : UserControl
    {
        public Image ShowingCommentImage { get; set; }
        public string ShowingCommentName { get; set; }
        public string ShowingCommentID { get; set; }
        public string ShowingCommentEmail { get; set; }
        public string ShowingCommentComment { get; set; }

        public ShowingComment()
        {
            InitializeComponent();
        }

        private void ShowingComment_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = ShowingCommentImage;
            bunifuCustomLabel1.Text = ShowingCommentName;
            //bunifuCustomLabel5.Text = ShowingCommentID;
            bunifuCustomLabel2.Text = ShowingCommentEmail;
            textBox1.Text = ShowingCommentComment;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SupportIT.Instance.Remove_Add(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
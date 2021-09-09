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
    public partial class SignUpAcceptedDeclined : UserControl
    {
        public Image SignUpAcceptedDeclinedImagePath { get; set; }
        public string SignUpAcceptedDeclinedName { get; set; }
        public string SignUpAcceptedDeclinedEmail { get; set; }

        //public int CalculateHeight(Label labell)
        //{
        //    Graphics g = labell.CreateGraphics();
        //    return Convert.ToInt32(g.MeasureString(labell.Text, labell.Font).Width);
        //}
        ////bunifuCustomLabel3.Height = CalculateHeight(bunifuCustomLabel3) / 14;

        public SignUpAcceptedDeclined()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpAcceptedDeclined_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = SignUpAcceptedDeclinedImagePath;
            bunifuCustomLabel1.Text = SignUpAcceptedDeclinedName;
            bunifuCustomLabel8.Text = SignUpAcceptedDeclinedEmail;
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Admin.Instance.AddAgain(this);
        }
    }
}
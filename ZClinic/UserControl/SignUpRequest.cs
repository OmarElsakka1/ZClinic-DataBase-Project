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
    public partial class SignUpRequest : UserControl
    {
        public Image SignUpRequestImagePath { get; set; }
        public string SignUpRequestName { get; set; }
        public string SignUpRequestEmail { get; set; }

        public SignUpRequest()
        {
            InitializeComponent();
        }

        private void SignUpRequest_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = SignUpRequestImagePath;
            bunifuCustomLabel1.Text = SignUpRequestName;
            bunifuCustomLabel8.Text = SignUpRequestEmail;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Admin.Instance.Accept(this);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Admin.Instance.Decline(this);
        }
    }
}
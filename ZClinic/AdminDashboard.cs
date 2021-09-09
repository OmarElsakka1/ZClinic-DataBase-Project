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
    public partial class AdminDashboard : Form
    {
        static AdminDashboard _obj;
        public static AdminDashboard Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new AdminDashboard();
                }
                return _obj;
            }
        }
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Instance.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportIT.Instance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Instance.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            AdminDashboard.Instance.Close();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            AdminDashboard.Instance.Close();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
            login.Instance.Show();
            SupportIT.Instance.Close();
            Admin.Instance.Close();
        }
    }
}
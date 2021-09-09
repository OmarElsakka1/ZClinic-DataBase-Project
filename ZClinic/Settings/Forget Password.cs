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
    public partial class Forget_Password : Form
    {
        Controller ControllerObj;
        string Username;
        string email;
        public Forget_Password(string username)
        {
            InitializeComponent();
            email = login.Mail;
            ControllerObj = new Controller();
            /*Username = username;
            Question1.Text = ControllerObj.get_QA(Username, "Question1");
            Question2.Text = ControllerObj.get_QA(Username, "Question2");*/
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetAnswers(email);
            if (dt == null)
            {

            }
            else 
            {
                char[] remove = { ' ', '.', ',' };
                if (dt.Rows[0].ItemArray[0].ToString() == Answer1.Text.Trim(remove).ToLower() && dt.Rows[0].ItemArray[1].ToString() == Answer2.Text.Trim(remove).ToLower())
                {
                    new NewPassword().Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Wrong Answers!");
                }
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forget_Password_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

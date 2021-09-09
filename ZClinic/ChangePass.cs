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
    public partial class ChangePassword : Form
    {
        Controller ControllerObj;
        string email;
        string National_ID;
        public ChangePassword()
        {
            InitializeComponent();
            email = login.Mail;
            National_ID = login.ID;
            ControllerObj = new Controller();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
           new EditProfile().Show();
        }

        private void NameTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            object Obj = ControllerObj.Get_Password(email);
            if (Obj == null)
            {
                MessageBox.Show("Fails!");
            }
            else if (Obj.ToString() == NameTextbox.Text)
            {
                if (bunifuMetroTextbox1.Text == bunifuMetroTextbox2.Text)
                {
                    int result = ControllerObj.UpdatePassword(National_ID, bunifuMetroTextbox1.Text);
                }
                else
                {
                    MessageBox.Show("Passwords are not similar!");
                }
            }
            else 
            {
                MessageBox.Show("Your own old password is wrong!");
            }
            
        }

        private void EditProfileButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new EditProfile().Show();
        }
    }
}

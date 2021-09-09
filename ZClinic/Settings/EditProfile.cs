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
    public partial class EditProfile : Form
    {
        string NationalId = login.ID;
        Int32 value;
        Controller ControllerObj;
        public EditProfile()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            //MoveSidePanel(EditProfileButton);
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(PhoneNumberTextbox.Text, out value))
            {
                MessageBox.Show("The Phone Number have to Be numerical!");
            }
            else if ((!(E_mailTextbox.Text).Contains('@')) || (!(E_mailTextbox.Text).Contains('.')))
            {
                MessageBox.Show("Invalid E-mail!");
            }
            else 
            {
                int result = ControllerObj.Edit_Profile(NationalId, NameTextbox.Text, E_mailTextbox.Text, PhoneNumberTextbox.Text);
                if(result == 0)
                {
                    MessageBox.Show("Edit Failed!");
                }
            }

        }
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            //MoveSidePanel(ChangePasswordButton);
            this.Hide();
            new ChangePassword().Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueSupportButton_Click(object sender, EventArgs e)
        {
            new Support().Show();
        }

        private void EditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
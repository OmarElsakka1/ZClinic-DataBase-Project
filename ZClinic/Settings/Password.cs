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
    public partial class Password : Form
    {
        int value;
        Controller Controllerobj;
        public Password()
        {
            InitializeComponent();
            Controllerobj = new Controller();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////
            ///                        delete it //////////////////////////////////////
            ///                        
            string National_ID = "098765456789";
            ///////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////
            ///

            string Email = Controllerobj.Get_Email_From_NationalID(National_ID).ToString();/////// How to make checks here
            string OldPass = Controllerobj.Get_Password(Email).ToString();
            if (OldPass == OldPassTextbox.Text)
            {
                MessageBox.Show("The old password is wrong!");
            }
            else
            {
                if (NewPassTextbox.Text == ConfirmNewPassTextbox.Text)
                {
                    int result = Controllerobj.UpdatePassword(National_ID, NewPassTextbox.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("Updating password fails!");
                    }
                }
                else 
                {
                    MessageBox.Show("Make sure the password is the same in both textboxs!");
                }
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                OldPassTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                OldPassTextbox.UseSystemPasswordChar = true;
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                NewPassTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                NewPassTextbox.UseSystemPasswordChar = true;
            }
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                ConfirmNewPassTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                ConfirmNewPassTextbox.UseSystemPasswordChar = true;
            }
        }

        private void Password_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
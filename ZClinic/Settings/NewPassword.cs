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
    public partial class NewPassword : Form
    {
        string email;
        string NationalID;
        Controller ControllerObj;
        string Username;
        public NewPassword()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            email = login.Mail;
            NationalID = login.ID;
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            if (EnterPasstextBox.Text == ConfirmPasstextBox.Text)
            {
                int result = ControllerObj.UpdatePassword(NationalID, EnterPasstextBox.Text); 
                if (result == 0)
                {
                    MessageBox.Show("Password is not Changed");
                }
                else
                {
                    MessageBox.Show("Password is successfully Changed!");
                }
                this.Hide();
            }
        }
    }
}

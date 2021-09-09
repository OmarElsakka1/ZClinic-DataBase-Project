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
    public partial class ContinueSignUp : Form
    {
        string NationalId;

        Controller ControllerObj;
        public ContinueSignUp()
        {
            InitializeComponent();
            ControllerObj = new Controller();
             NationalId=SignUp.NID;
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            Int32 value;
            if (IDtextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter your own ID!");
            }
            else if (!Int32.TryParse(IDtextBox.Text.Trim(), out value))
            {
                MessageBox.Show("ID have to be numerical!");
            }
            else if (IDtextBox.Text.Trim().Contains('.'))
            {
                MessageBox.Show("ID should not contain '.' !");
            }
            else if (comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter your own Major!");
            }
            else
            {
                int result = ControllerObj.SET_STUDENT(IDtextBox.Text, comboBox1.Text,NationalId);
                if (result == 0)
                {
                    MessageBox.Show("Query fails");
                }
                else
                {
                    this.Hide();
                    new Medical_info().Show();
                }
            }
        }
    }
}
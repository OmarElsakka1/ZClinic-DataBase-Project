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
    public partial class Form1 : Form
    {
        Controller ControllerObj;
        public Form1()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            if (UsernametextBox.Text.Trim() != "")
            {
                object Obj = ControllerObj.Get_Password(UsernametextBox.Text.Trim().ToLower());
                if (PasswordtestBox.Text == "")
                {
                    MessageBox.Show("Please,Enter the password!");
                }
                else
                {
                    if (Obj == null)
                    {
                        MessageBox.Show("Query fails!");
                    }
                    else if (PasswordtestBox.Text == Obj.ToString())
                    {
                        this.Hide();
                        Dashboard.Instance.Show();
                    }
                }
            }


            /*string password = ControllerObj.Accounts(UsernametextBox.Text);
            if (password == PasswordtestBox.Text)
            {
                string type = ControllerObj.get_Type(UsernametextBox.Text);
            }
            else
            {
                MessageBox.Show("Enter correct Username and password");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*if ()//check exist or not!
            {
                new Forget_Password(UsernametextBox.Text).Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Ok,Enter the Username Correctly First!");
            }*/
            
        }
    }
}

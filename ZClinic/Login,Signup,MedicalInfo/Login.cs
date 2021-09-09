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
    public partial class login : Form
    {
        Controller ControllerObj;
        static login _obj;
        static bool Closed = false;
        static string NationalID = "";
        static string Type = "";
        static string Email = "";
        public static string TYPE
        {
            get
            {
                return Type;
            }
        }
        public static string Mail
        {
            get
            {
                return Email;
            }
        }
        public static string ID
        {
            get 
            {
                return NationalID;
            }
        }
        public static login Instance
        {
            get
            {
                if (_obj == null && Closed == false)
                {
                    _obj = new login();
                }
                return _obj;
            }
        
        }

        public login()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Wrong Username or Password");
                    }
                    else if (PasswordtestBox.Text == Obj.ToString())
                    {
                        object result2 = ControllerObj.Get_NationalID(UsernametextBox.Text);
                        Email = UsernametextBox.Text;


                        if (result2 == null)
                        {

                        }
                        else
                        {
                           
                            object result3 = ControllerObj.Get_Type(UsernametextBox.Text);
                            if (result3 == null)
                            {

                            }
                            else
                            {
                                NationalID = result2.ToString();
                                Type = result3.ToString();
                            }


                        }
                        this.Hide();
                        if(Type!= "Admin")
                        {
                            Dashboard.Instance.Show();
                        }
                        else
                        {
                            AdminDashboard.Instance.Show();
                        }
                        
                    }
                }
            }
            else 
            {
                MessageBox.Show("Enter the username!");
            }
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void Forgetpasswordlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ControllerObj.IsUserExist(UsernametextBox.Text.Trim().ToLower()) == 1)
            {
                new Forget_Password(UsernametextBox.Text).Show();
                //this.Hide();
            }
            else 
            {
                MessageBox.Show("Ok,Enter the Username Correctly First!");
            }
        }


        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                PasswordtestBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordtestBox.UseSystemPasswordChar = true;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
           // Drugs.Instance.Close();
            //ContactDevelopers.Instance.Close();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
            Closed = true;
            NationalID = "";

        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            _obj = null;
            Closed = true;
            NationalID = "";
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EmergencyForm().Show();
        }
    }
}
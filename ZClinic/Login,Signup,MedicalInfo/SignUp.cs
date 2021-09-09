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
    public partial class SignUp : Form
    {
        string imagePath = Application.StartupPath + @"\Images";
        string ImageName="";
        string destinationFile = "";
        bool token = true;
        static string NationalID = "";
        static string BirthDate = "";
        public static string BD
        {
            get
            {
                return BirthDate;
            }
        }
        public static string NID
        {
            get
            {
                return NationalID;
            }
        }
        Controller ControllerObj;
        public SignUp()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            Tick.Hide();
            Tock.Hide();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            Char Sex ='M';
            Int32 value;
            bool AA = Int32.TryParse(PhonenumbertextBox.Text, out value);
            bool AAA = Int32.TryParse(NationalIDtextBox.Text, out value);
            bool AAAA = (!PhonenumbertextBox.Text.Contains('.'));
            bool AAAAA = (!NationalIDtextBox.Text.Contains('.'));
            if (Int32.TryParse(PhonenumbertextBox.Text, out value) && Int32.TryParse(NationalIDtextBox.Text, out value) && (!PhonenumbertextBox.Text.Contains('.')) && (!NationalIDtextBox.Text.Contains('.')))
            {
                if (PasswordtextBox.Text == ConfirmPasswordtextBox.Text)
                {
                    if (!radioButton1.Checked && !radioButton2.Checked)
                    {
                        MessageBox.Show("Please, Enter the genter!");
                    }
                    else if (A1_textBox.Text == "")
                    {
                        MessageBox.Show("Answer the first Question!");
                    }
                    else if (A2_textBox.Text == "")
                    {
                        MessageBox.Show("Answer the second Question!");
                    }
                    else if (!E_mailtextBox.Text.Contains('@') || (!E_mailtextBox.Text.Contains('.')))
                    {
                        MessageBox.Show("Enter a vaild E-mail!");
                    }
                    else if (ImageName=="")
                    {
                        MessageBox.Show("Please Select an Image First!");
                    }
                    else
                    {
                        if (radioButton1.Checked)
                        {
                            Sex = 'M';
                        }
                        if (radioButton2.Checked)
                        {
                            Sex = 'F';
                        }
                        char[] remove = { ' ', '.', ',' };
                        int result = ControllerObj.InsertUser(NationalIDtextBox.Text, PhonenumbertextBox.Text, TypecomboBox.Text, PasswordtextBox.Text, E_mailtextBox.Text.Trim().ToLower(), NametextBox.Text, Sex, A1_textBox.Text.Trim(remove).ToLower(), A2_textBox.Text.Trim(remove).ToLower(),ImageName);
                        this.Hide();
                        if (result == 0)
                        {

                            MessageBox.Show("No data added to the database!");
                            System.IO.File.Delete(destinationFile);
                        }
                        else
                        {
                            NationalID = NationalIDtextBox.Text;
                            BirthDate = dateTimePicker.Value.Date.ToString();
                            if (TypecomboBox.Text == "Student")
                            {
                                new ContinueSignUp().Show();
                            }
                            else if (TypecomboBox.Text == "Doctor")
                            {
                                new ContinueDoctorSignUp().Show();
                            }
                            else
                            {
                                new Medical_info().Show();
                            }

                            //new Login_Signup_MedicalInfo.Medical_info(NationalIDtextBox.Text, dateTimePicker.Text).Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Make sure that the Password is the same as the confirm Password!");
                }
            }
            else if (PhonenumbertextBox.Text.Contains('.'))
            {
                MessageBox.Show("Phone number should not contain decimal!");
            }
            else if (NationalIDtextBox.Text.Contains('.'))
            {
                MessageBox.Show("Naitonal ID should not contain decimal!");
            }
            else
            {
                MessageBox.Show("Make Sure that you entered a valid data!");
            }
        }

        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Instance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();

            OpenFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            OpenFileDialog1.Title = "Open Image";

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Fallpath = OpenFileDialog1.FileName;
                 ImageName = OpenFileDialog1.SafeFileName;
                if (ImageName != "")
                {
                    if (ControllerObj.CheckUsersImage(ImageName) == 1 || ControllerObj.CheckMSuppliesImage(ImageName) == 1)
                    {
                        MessageBox.Show("Choose Another Image Name");
                        token = true;
                        Tick.Hide();
                        Tock.Show();
                        ImageName = "";
                    }
                    else
                    {
                        token = false;
                       
                        
                        string sourceFile = Fallpath;
                         destinationFile = imagePath + @"\" + ImageName;
                        try
                        {
                            System.IO.File.Copy(sourceFile, destinationFile);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Image Already Present");
                            token = true;
                           
                        }
                        if(token==false)
                        {
                            Tick.Show();
                            Tock.Hide();

                        }
                        else if(token == true)
                        {
                            Tick.Hide();
                            Tock.Show();
                        }
                        
                    }
                   

                }
                else
                {
                    OpenFileDialog1.ShowDialog();
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();

            OpenFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            OpenFileDialog1.Title = "Open Image";

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Fallpath = OpenFileDialog1.FileName;
                ImageName = OpenFileDialog1.SafeFileName;
                if (ImageName != "")
                {
                    if (ControllerObj.CheckUsersImage(ImageName) == 1 || ControllerObj.CheckMSuppliesImage(ImageName) == 1)
                    {
                        MessageBox.Show("Choose Another Image Name");
                        token = true;
                        Tick.Hide();
                        Tock.Show();
                        ImageName = "";
                    }
                    else
                    {
                        token = false;


                        string sourceFile = Fallpath;
                        string destinationFile = imagePath + @"\" + ImageName;
                        try
                        {
                            System.IO.File.Copy(sourceFile, destinationFile);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Image Already Present");
                            token = true;

                        }
                        if (token == false)
                        {
                            Tick.Show();
                            Tock.Hide();

                        }
                        else if (token == true)
                        {
                            Tick.Hide();
                            Tock.Show();
                        }

                    }


                }
                else
                {
                    OpenFileDialog1.ShowDialog();
                }
            }
        }
    }
}
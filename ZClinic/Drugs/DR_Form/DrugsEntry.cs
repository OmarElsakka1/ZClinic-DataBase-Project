using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;


namespace ZClinic
{
    public partial class DrugsEntry : Form
    {
        bool token = true;
        string sourceFile = "";
        string destinationFile = "";
        string imagePath = Application.StartupPath + @"\Images";
        string ImageName = "";
        Controller ControllerObj;
        public DrugsEntry()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            Int32 value;
            if (DrugNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Drug Name!");
            }
            else
            {
                if (PriceTextBox.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter the price!");
                }
                else if (!Int32.TryParse(PriceTextBox.Text, out value))
                {
                    MessageBox.Show("The price have to be numberical!");
                }
                else if (ImageName == "")
                {
                    MessageBox.Show("Please Select an Image First!");
                }
                else
                {
                    if (AvailableTextBox.Text.Trim() == "")
                    {
                        MessageBox.Show("Please Enter the Available!");
                    }
                    else if (!Int32.TryParse(AvailableTextBox.Text, out value))
                    {
                        MessageBox.Show("The Available have to be numberical!");
                    }
                    else
                    {
                        if (FullStockTextBox.Text.Trim() == "")
                        {
                            MessageBox.Show("Please Enter the Full Stock!");
                        }
                        else if (!Int32.TryParse(FullStockTextBox.Text, out value))
                        {
                            MessageBox.Show("The Full Stock have to be numberical!");
                        }
                        else
                        {
                            if (DescriptionTextBox.Text == "")
                            {
                                MessageBox.Show("Please Enter the Description!");
                            }
                            else
                            {
                                int result = ControllerObj.Insert_Drug_Data(DrugNameTextBox.Text, Double.Parse(PriceTextBox.Text), Int32.Parse(AvailableTextBox.Text), Int32.Parse(FullStockTextBox.Text), ImageName, DescriptionTextBox.Text);
                                if (result == 0)
                                {
                                    MessageBox.Show("No data Entered!");
                                    System.IO.File.Delete(destinationFile);
                                }
                                DrugNameTextBox.Text = "";
                                PriceTextBox.Text = "";
                                AvailableTextBox.Text = "";
                                FullStockTextBox.Text = "";
                                DescriptionTextBox.Text = "";
                                Tick.Hide();
                                Tock.Hide();
                                PopupNotifier popup = new PopupNotifier();
                                popup.Image = Properties.Resources.checkmark_48px;
                                popup.TitleText = "Congrats!";
                                popup.TitleColor = Color.Chocolate;
                                popup.TitleFont = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                popup.ContentFont = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                popup.BodyColor = Color.DeepSkyBlue;
                                popup.ContentText = "Medicine Added Successfully";
                                popup.Popup();

                            }
                        }
                    }
                }
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrugsEntry_FormClosed(object sender, FormClosedEventArgs e)
        {

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


                         sourceFile = Fallpath;
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
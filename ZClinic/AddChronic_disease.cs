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
    public partial class AddChronic_disease : Form
    {
        Controller ControllerObj;
        string National_ID;
        public AddChronic_disease(string NationalID)
        {
            InitializeComponent();
            ControllerObj = new Controller();
            National_ID = NationalID;
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (Chronic_disease_textBox.Text != "")
            {
                result = ControllerObj.Insert_Chronic_Disease(Chronic_disease_textBox.Text, National_ID);
            }
            if (result == 0)
            {
                MessageBox.Show("No data entered");
            }
            else
            {
                MessageBox.Show("The data is entered successfully");
                login.Instance.Show();
            }
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

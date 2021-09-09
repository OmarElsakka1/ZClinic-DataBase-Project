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
    public partial class Medical_info : Form
    {
        Controller ControllerObj;
        string Bdate;
        string National_ID;
        int value;
        public Medical_info()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            Bdate = SignUp.BD;
            National_ID = SignUp.NID;
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            Int32 value;
            int result1 = 0;
            if (Int32.TryParse(WeighttextBox.Text, out value) && Int32.TryParse(HeighttextBox.Text, out value))
            {
                if (NotesBox.Text.Trim() == "")
                {
                    result1 = ControllerObj.Insert_Medical_infoNULL(comboBox1.Text, Bdate, HeighttextBox.Text, WeighttextBox.Text, National_ID);
                }
                else
                {
                    result1 = ControllerObj.Insert_Medical_info(comboBox1.Text, Bdate, HeighttextBox.Text, WeighttextBox.Text, National_ID, NotesBox.Text);

                }
                if (result1 == 0)
                {
                    MessageBox.Show("No data entered");
                }
                else
                {
                    MessageBox.Show("The data is entered successfully");
                    login.Instance.Show();
                }
            }
            else
            {
                MessageBox.Show("Enter a valid data!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddChronic_disease(National_ID).Show();
        }
    }
}
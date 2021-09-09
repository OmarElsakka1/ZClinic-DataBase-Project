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
    public partial class ContinueDoctorSignUp : Form
    {
        string NationalId;
        Controller ControllerObj;
        public ContinueDoctorSignUp()
        {
            InitializeComponent();
            NationalId = SignUp.NID;
            ControllerObj = new Controller();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            string Specialization = IDtextBox.Text;
            int result = ControllerObj.Insert_Doctor(NationalId, Specialization);
            if (result == 0)
            {
                MessageBox.Show("No Data entered!");
            }
            else
            {
                this.Hide();
                new Medical_info().Show();
            }
        }

    }
}

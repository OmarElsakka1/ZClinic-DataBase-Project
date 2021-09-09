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
    public partial class AppointmentDoctorMini : UserControl
    {
        public Image DoctorImage { get; set; }

        public string DoctorName { get; set; }

        public string DoctorAge { get; set; }

        public string DoctorSpecialization { get; set; }

        public string BookDate { get; set; }

        public AppointmentDoctorMini()
        {
            InitializeComponent();
        }

        private void AppointmentDoctorMini_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = DoctorImage;
            bunifuCustomLabel1.Text= DoctorName;
            bunifuCustomLabel2.Text = DoctorAge;
            bunifuCustomLabel9.Text = DoctorSpecialization;
            bunifuCustomLabel6.Text = BookDate;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            BookAppointment.Instance.RemoveApp(this);
        }
    }
}

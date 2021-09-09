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
    public partial class AppointmentDoctor : UserControl
    {
        public Image DoctorImage { get; set; }

        public string DoctorName { get; set; }

        public string DoctorAge { get; set; }

        public string DoctorSpecialization { get; set; }

        public string BookDate { get; set; }

        bool processing=false;

        public AppointmentDoctor()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //call an instance and func
           // if(bunifuDatepicker1.Value.Date==)
            BookAppointment.Instance.Booker(this);

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            //click on label or click on check mark 
            //BookAppointment.Instance.Booker(this);
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            if(processing==false)
             {
                if (bunifuDatepicker1.Value.Date.CompareTo(System.DateTime.Today.Date) > 0)
                {
                    DayOfWeek F = (DayOfWeek)5;
                    DayOfWeek M = bunifuDatepicker1.Value.DayOfWeek;

                    if (M == (DayOfWeek)5 || M == (DayOfWeek)6)
                    {
                        processing = true;
                        MessageBox.Show("Can't Book an Appointment during holiday");
                        bunifuDatepicker1.Value = System.DateTime.Today;
                        processing = false;
                    }
                    else
                    {
                        processing = true;
                        bunifuCustomLabel6.Text = bunifuDatepicker1.Value.ToShortDateString();
                        BookDate = bunifuCustomLabel6.Text;
                        processing = false;
                    }

                }
                else
                {
                    processing = true;
                    bunifuDatepicker1.Value = System.DateTime.Today;
                    MessageBox.Show("This Date has already passed, select an upcoming date");
                    //bunifuDatepicker1.Value.AddDays(System.DateTime.Today.Subtract(bunifuDatepicker1.Value).TotalDays);
                    processing = false;


                }
            }
        }

        private void AppointmentDoctor_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = DoctorImage;
            bunifuCustomLabel1.Text = DoctorName;
            bunifuCustomLabel2.Text = DoctorAge;
            bunifuCustomLabel9.Text = DoctorSpecialization;
            BookDate= bunifuCustomLabel6.Text;
        }
    }
}

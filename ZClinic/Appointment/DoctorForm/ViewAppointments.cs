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
    public partial class ViewAppointments : Form
    {
        static ViewAppointments _obj;
        public static ViewAppointments Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ViewAppointments();
                }
                return _obj;
            }
        }
        string NationalId;
        string Type;
        public ViewAppointments()
        {
            InitializeComponent();
            NationalId = login.ID;
            Type = login.TYPE;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Dashboard.Instance != null)//close handled
            {
                Dashboard.Instance.Close();
            }
            if (BookAppointment.Instance != null)//close handled
            {
                BookAppointment.Instance.Close();
            }
            if (MedicalExcuses.Instance != null)//close handled
            {
                MedicalExcuses.Instance.Close();
            }
            if (ViewAppointments.Instance != null)//close handled
            {
                ViewAppointments.Instance.Close();
            }
            if (RequestMedicalExcuse.Instance != null)//close handled
            {
                RequestMedicalExcuse.Instance.Close();
            }
            if (ContactDevelopers.Instance != null)//close handled
            {
                ContactDevelopers.Instance.Close();
            }
            if (Drugs.Instance != null)//close handled
            {
                Drugs.Instance.Close();
            }
            if (OrderDrugs.Instance != null)//close handled
            {
                OrderDrugs.Instance.Close();
            }
            if (Hospital.Instance != null)//Close Handled
            {
                Hospital.Instance.Close();
            }
            if (SupportUser.Instance != null)
            {
                SupportUser.Instance.Close();
            }
        }

        private void ViewAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Dashboard.Instance != null)//close handled
            {
                Dashboard.Instance.Close();
            }
            if (BookAppointment.Instance != null)//close handled
            {
                BookAppointment.Instance.Close();
            }
            if (MedicalExcuses.Instance != null)//close handled
            {
                MedicalExcuses.Instance.Close();
            }
            if (ViewAppointments.Instance != null)//close handled
            {
                ViewAppointments.Instance.Close();
            }
            if (RequestMedicalExcuse.Instance != null)//close handled
            {
                RequestMedicalExcuse.Instance.Close();
            }
            if (ContactDevelopers.Instance != null)//close handled
            {
                ContactDevelopers.Instance.Close();
            }
            if (Drugs.Instance != null)//close handled
            {
                Drugs.Instance.Close();
            }
            if (OrderDrugs.Instance != null)//close handled
            {
                OrderDrugs.Instance.Close();
            }
            if (Hospital.Instance != null)//Close Handled
            {
                Hospital.Instance.Close();
            }
            if (SupportUser.Instance != null)
            {
                SupportUser.Instance.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (Type == "Student")
            {
                this.Hide();
                RequestMedicalExcuse.Instance.Show();

            }
            else if (Type == "Doctor")
            {
                this.Hide();
                MedicalExcuses.Instance.Show();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (Type == "Nurse" || Type == "Doctor")
            {
                new DrugsEntry().Show();
            }
            else if (Type == "Student" || Type == "Teaching Stuff" || Type == "Admin")
            {
                this.Hide();
                Drugs.Instance.Show();
            }

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospital.Instance.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Type == "Admin")
            {
                //Support Admin
            }
            else if (Type == "Student" || Type == "Teaching Stuff" || Type == "Nurse" || Type == "Doctor")
            {
                SupportUser.Instance.Show();
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

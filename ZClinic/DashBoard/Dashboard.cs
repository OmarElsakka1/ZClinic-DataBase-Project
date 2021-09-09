using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//timer in hospital
namespace ZClinic
{
    public partial class Dashboard : Form
    {
        string NationalId;
        string Type;
        static Dashboard _obj;
        public static Dashboard Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Dashboard();
                }
                return _obj;
            }
        }
        public Dashboard()
        {
            InitializeComponent();

            if (this.BackColor == Color.FromArgb(50, 49, 69))
            {
                LTD.Hide();
                DTL.Show();
            }
            if (this.BackColor == Color.White)
            {
                LTD.Hide();
                DTL.Show();
            }
            NationalId =login.ID;
            Type = login.TYPE;
            if (Type != "Admin")
            {
                bunifuFlatButton7.Visible = true;
            }
            else
            {
                bunifuFlatButton7.Visible = false;
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            
            if(Type=="Nurse" ||Type=="Doctor")
            {
                new DrugsEntry().Show();
            }
            else if(Type == "Student"|| Type == "Teaching Stuff"|| Type== "Admin")
            {
                this.Hide();
                Drugs.Instance.Show();
            }
            
            //new OrderDrugs().Show();
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

            //new Support().Show();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (Type == "Nurse" || Type == "Doctor")
            {
                ViewAppointments.Instance.Show(); 
            }
            else if (Type == "Student" || Type == "Teaching Stuff" || Type == "Admin")
            {
                this.Hide();
                BookAppointment.Instance.Show();
            }
            // new Appointment().Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if(Type=="Student"|| Type == "Teaching Stuff")
            {
                this.Hide();
                RequestMedicalExcuse.Instance.Show();

            }
            else if (Type=="Doctor")
            {
                this.Hide();
                MedicalExcuses.Instance.Show();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
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
            if(TeachingStuffMedicalExcuses.Instance!=null)
            {
                TeachingStuffMedicalExcuses.Instance.Close();
            }
            login.Instance.Show();

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospital.Instance.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void LTD_Click(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(this, Color.FromArgb(50, 49, 69), XanderUI.XUIObjectAnimator.ColorAnimation.FillEllipse, true, 1);
            Welcome.ForeColor = Color.WhiteSmoke;
            To.ForeColor = Color.WhiteSmoke;
            ZCLINIC.ForeColor = Color.WhiteSmoke;
            if (this.BackColor == Color.FromArgb(50, 49, 69))
            {
                LTD.Hide();
                DTL.Show();
            }
            if (this.BackColor == Color.WhiteSmoke)
            {
                LTD.Show();
                DTL.Hide();
            }
        }

        private void DTL_Click(object sender, EventArgs e)
        {
            xuiObjectAnimator.ColorAnimate(this, Color.WhiteSmoke, XanderUI.XUIObjectAnimator.ColorAnimation.FillEllipse, true, 1);
            Welcome.ForeColor = Color.Black;
            To.ForeColor = Color.Black;
            ZCLINIC.ForeColor = Color.Black;
            if (this.BackColor == Color.FromArgb(50, 49, 69))
            {
                LTD.Hide();
                DTL.Show();
            }
            if (this.BackColor == Color.WhiteSmoke)
            {
                LTD.Show();
                DTL.Hide();
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //make visible only if doctor.
        }
    }
}

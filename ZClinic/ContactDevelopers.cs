using QRCoder;
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
    public partial class ContactDevelopers : Form
    {
        string NationalId;
        string Type;
        static ContactDevelopers _obj;
        public static ContactDevelopers Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new ContactDevelopers();
                }
                return _obj;
            }
        }
        public ContactDevelopers()
        {
            InitializeComponent();
            NationalId = login.ID;
            Type = login.TYPE;
            QRCodeGenerator qr = new QRCodeGenerator();
            string enter = "https://docs.google.com/forms/d/e/1FAIpQLSei4M6MAvM5zDrp-z3GKAJW2aUKbQL_yH5C9RIY9AEmY5k3fw/viewform?usp=sf_link";
            QRCodeData data = qr.CreateQrCode(enter, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(2);
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
            //this.Close();
            //Drugs.Instance.Close();
            //new login().Show();

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new ChangePassword().Show();
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (Type == "Student" || Type == "Teaching Stuff")
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

        private void ContactDevelopers_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
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
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospital.Instance.Show();
        }
    }
}

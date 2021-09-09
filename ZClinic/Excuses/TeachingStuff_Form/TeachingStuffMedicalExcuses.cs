using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZClinic.Model;


namespace ZClinic
{
    public partial class TeachingStuffMedicalExcuses : Form
    {
        static TeachingStuffMedicalExcuses _obj;
        public static TeachingStuffMedicalExcuses Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new TeachingStuffMedicalExcuses();
                }
                return _obj;
            }
        }
        string NationalId;
        string Type;
        string imagePath = Application.StartupPath + @"\Images";
        Controller ControllerObj;
        public TeachingStuffMedicalExcuses()
        {
            InitializeComponent();
            NationalId = login.ID;
            Type = login.TYPE;
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.TeachingMedicalEcxcuses(NationalId);
            List<TeachingStuffClass> ExcusesList = new List<TeachingStuffClass>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // Note this will be done once for each medicalexcuse
                    TeachingStuffClass E = new TeachingStuffClass
                    {
                        Name = dt.Rows[i].ItemArray[9].ToString(),
                        Major = dt.Rows[i].ItemArray[7].ToString(),
                        StartDate = dt.Rows[i].ItemArray[0].ToString(),
                        EndDate = dt.Rows[i].ItemArray[1].ToString(),
                        ImagePath = imagePath + @"\" + dt.Rows[i].ItemArray[10].ToString(),
                        Symptom1 = dt.Rows[i].ItemArray[2].ToString(),
                        Symptom2 = dt.Rows[i].ItemArray[3].ToString(),
                        Symptom3 = dt.Rows[i].ItemArray[4].ToString(),
                        Symptom4 = dt.Rows[i].ItemArray[5].ToString(),
                        ID = dt.Rows[i].ItemArray[6].ToString(),
                        state = dt.Rows[i].ItemArray[8].ToString()
                    };
                    ExcusesList.Add(E);
                }
                foreach (var Excuse in ExcusesList)
                {
                    TeachingStuffMedicalControl Exc = new TeachingStuffMedicalControl();
                    Exc.ExcuseName = Excuse.Name;
                    Exc.ExcuseMajor = Excuse.Major;
                    Exc.ExcuseStartDate = Excuse.StartDate;
                    Exc.ExcuseEndDate = Excuse.EndDate;
                    Exc.ExcuseImage = Image.FromFile(Excuse.ImagePath);
                    Exc.ExcuseSymptom1 = Excuse.Symptom1;
                    Exc.ExcuseSymptom2 = Excuse.Symptom2;
                    Exc.ExcuseSymptom3 = Excuse.Symptom3;
                    Exc.ExcuseSymptom4 = Excuse.Symptom4;
                    Exc.ExcuseID = Excuse.ID;
                    if (Excuse.state == "True")
                    {
                        flowLayoutPanel1.Controls.Add(Exc);
                    }
                    else if (Excuse.state == "False")
                    {
                        flowLayoutPanel2.Controls.Add(Exc);
                    }

                }
            }

           
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestMedicalExcuse.Instance.Show();
        }

        private void TeachingStuffMedicalExcuses_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

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

        private void TeachingStuffMedicalExcuses_FormClosing(object sender, FormClosingEventArgs e)
        {
            _obj = null;
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            //to be implemented
        }
    }
}

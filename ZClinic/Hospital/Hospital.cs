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
    public partial class Hospital : Form
    {
        static Hospital _obj;
        string NationalId;
        string Type;
        public static Hospital Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Hospital();
                }
                return _obj;
            }
        }
        Hospitals mControl;
        //Medicens hControl;
        List<Hospitals> cartlist = new List<Hospitals>();
        Controller ControllerObj;
        public Hospital()
        {
            InitializeComponent();
            NationalId = login.ID;
            Type = login.TYPE;
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.Hosptials_Data();
           //Issue  // 1.The form is static 2.Querey in constructor 3.while loop needed to refresh 4. won't exit

            List<HospitalClass> hospitalsList = new List<HospitalClass>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HospitalClass A = new HospitalClass
                {
                    Name = dt.Rows[i].ItemArray[0].ToString(),
                    Address = dt.Rows[i].ItemArray[1].ToString(),
                    LinkMap = dt.Rows[i].ItemArray[2].ToString(),
                    PhoneNumber = dt.Rows[i].ItemArray[3].ToString()
                };
                hospitalsList.Add(A);
            }

            foreach (var hospital in hospitalsList)
            {
                Hospitals hospitall = new Hospitals();
                hospitall.hospitalName = hospital.Name;
                hospitall.hospitalAddress = hospital.Address;
                hospitall.hospitalLinkMap = hospital.LinkMap;
                hospitall.hospitalPhoneNumber = hospital.PhoneNumber;
                flowLayoutPanel1.Controls.Add(hospitall);
                //hospitall.MouseDown += Hospitals_MouseDown;
            }
        }

        //private void Hospitals_MouseDown(object sender, MouseEventArgs e)
        //{
        //    mControl = (Hospitals)sender;
        //    Bitmap bitmap = new Bitmap(mControl.Width, mControl.Height);
        //    mControl.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
        //    Cursor cursor = new Cursor(bitmap.GetHicon());
        //    Cursor.Current = cursor;
        //    this.DoDragDrop(mControl, DragDropEffects.All);
        //}

        private void Hospital_Load(object sender, EventArgs e)
        {

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Instance.Show();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Dashboard.Instance.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
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

        private void Hospital_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }
    }
}

//timer
/*private void Form1_Load(object sender, EventArgs e)
{
    Timer timer = new Timer();
    timer.Interval = (10 * 1000); // 10 secs
    timer.Tick += new EventHandler(timer_Tick);
    timer.Start();
}

private void timer_Tick(object sender, EventArgs e)
{
    //refresh here...
}*/
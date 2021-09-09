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
    public partial class RequestMedicalExcuse : Form
    {
        DateTime dt1, dt2;
        DateTime Tod = DateTime.Today;
        DateTime today = DateTime.Today;
        string imagePath = Application.StartupPath + @"\Images";
        List<TBM> Teachinglist = new List<TBM>();
        Controller ControllerObj;
        string NationalId;
        string Type;
        static RequestMedicalExcuse _obj;
        public static RequestMedicalExcuse Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new RequestMedicalExcuse();
                }
                return _obj;
            }
        }
        public RequestMedicalExcuse()
        {
            InitializeComponent();
            bunifuDatepicker1.Value= DateTime.Today;
            bunifuDatepicker2.Value = DateTime.Today.AddDays(1) ;
            NationalId = login.ID;
            Type = login.TYPE;
            ControllerObj = new Controller();
            panel4.Show();
            panel5.Hide();
            DataTable dA = ControllerObj.GetAllAcceptedMedicalExcusesPerUSer();
            DataTable dD = ControllerObj.GetAllDeclinedMedicalExcusesPerUSer();
            DataTable dP = ControllerObj.GetAllPendingMedicalExcusesPerUSer();

            List<ExecusesClass> AcceptedList = new List<ExecusesClass>();
            List<ExecusesClass> DeclinedList = new List<ExecusesClass>();
            List<ExecusesClass> PendingList = new List<ExecusesClass>();
            if (dA != null)
            {
                for (int i = 0; i < dA.Rows.Count; i++)
                {
                    // Note this will be done once for each medicalexcuse
                    ExecusesClass E = new ExecusesClass
                    {
                        Name = dA.Rows[i].ItemArray[0].ToString(),
                        Age = dA.Rows[i].ItemArray[1].ToString(),
                        Major = dA.Rows[i].ItemArray[2].ToString(),
                        StartDate = dA.Rows[i].ItemArray[3].ToString(),
                        EndDate = dA.Rows[i].ItemArray[4].ToString(),
                        ImagePath = imagePath + @"\" + dA.Rows[i].ItemArray[5].ToString(),
                        Symptom1 = dA.Rows[i].ItemArray[6].ToString(),
                        Symptom2 = dA.Rows[i].ItemArray[7].ToString(),
                        Symptom3 = dA.Rows[i].ItemArray[8].ToString(),
                        Symptom4 = dA.Rows[i].ItemArray[9].ToString(),
                    };
                    AcceptedList.Add(E);

                }

                foreach (var Excuse in AcceptedList)
                {
                    ADMEP Exc = new ADMEP();
                    Exc.ExcuseName = Excuse.Name;
                    Exc.ExcuseAge = Excuse.Age;
                    Exc.ExcuseMajor = Excuse.Major;
                    Exc.ExcuseStartDate = Excuse.StartDate;
                    Exc.ExcuseEndDate = Excuse.EndDate;
                    Exc.ExcuseImage = Image.FromFile(Excuse.ImagePath);
                    Exc.ExcuseSymptom1 = Excuse.Symptom1;
                    Exc.ExcuseSymptom2 = Excuse.Symptom2;
                    Exc.ExcuseSymptom3 = Excuse.Symptom3;
                    Exc.ExcuseSymptom4 = Excuse.Symptom4;

                    flowLayoutPanel1.Controls.Add(Exc);
                }
            }
            if (dD != null)
            {
                for (int i = 0; i < dD.Rows.Count; i++)
                {
                    // Note this will be done once for each medicalexcuse
                    ExecusesClass E = new ExecusesClass
                    {
                        Name = dD.Rows[i].ItemArray[0].ToString(),
                        Age = dD.Rows[i].ItemArray[1].ToString(),
                        Major = dD.Rows[i].ItemArray[2].ToString(),
                        StartDate = dD.Rows[i].ItemArray[3].ToString(),
                        EndDate = dD.Rows[i].ItemArray[4].ToString(),
                        ImagePath = imagePath + @"\" + dD.Rows[i].ItemArray[5].ToString(),
                        Symptom1 = dD.Rows[i].ItemArray[6].ToString(),
                        Symptom2 = dD.Rows[i].ItemArray[7].ToString(),
                        Symptom3 = dD.Rows[i].ItemArray[8].ToString(),
                        Symptom4 = dD.Rows[i].ItemArray[9].ToString(),
                    };
                    DeclinedList.Add(E);

                }


                foreach (var Excuse in DeclinedList)
                {
                    ADMEP Exc = new ADMEP();
                    Exc.ExcuseName = Excuse.Name;
                    Exc.ExcuseAge = Excuse.Age;
                    Exc.ExcuseMajor = Excuse.Major;
                    Exc.ExcuseStartDate = Excuse.StartDate;
                    Exc.ExcuseEndDate = Excuse.EndDate;
                    Exc.ExcuseImage = Image.FromFile(Excuse.ImagePath);
                    Exc.ExcuseSymptom1 = Excuse.Symptom1;
                    Exc.ExcuseSymptom2 = Excuse.Symptom2;
                    Exc.ExcuseSymptom3 = Excuse.Symptom3;
                    Exc.ExcuseSymptom4 = Excuse.Symptom4;

                    flowLayoutPanel2.Controls.Add(Exc);
                }
            }
            if (dP != null)
            {
                for (int i = 0; i < dP.Rows.Count; i++)
                {
                    // Note this will be done once for each medicalexcuse
                    ExecusesClass E = new ExecusesClass
                    {
                        Name = dP.Rows[i].ItemArray[0].ToString(),
                        Age = dP.Rows[i].ItemArray[1].ToString(),
                        Major = dP.Rows[i].ItemArray[2].ToString(),
                        StartDate = dP.Rows[i].ItemArray[3].ToString(),
                        EndDate = dP.Rows[i].ItemArray[4].ToString(),
                        ImagePath = imagePath + @"\" + dP.Rows[i].ItemArray[5].ToString(),
                        Symptom1 = dP.Rows[i].ItemArray[6].ToString(),
                        Symptom2 = dP.Rows[i].ItemArray[7].ToString(),
                        Symptom3 = dP.Rows[i].ItemArray[8].ToString(),
                        Symptom4 = dP.Rows[i].ItemArray[9].ToString(),
                    };
                    PendingList.Add(E);

                }

                foreach (var Excuse in PendingList)
                {
                    ADMEP Exc = new ADMEP();
                    Exc.ExcuseName = Excuse.Name;
                    Exc.ExcuseAge = Excuse.Age;
                    Exc.ExcuseMajor = Excuse.Major;
                    Exc.ExcuseStartDate = Excuse.StartDate;
                    Exc.ExcuseEndDate = Excuse.EndDate;
                    Exc.ExcuseImage = Image.FromFile(Excuse.ImagePath);
                    Exc.ExcuseSymptom1 = Excuse.Symptom1;
                    Exc.ExcuseSymptom2 = Excuse.Symptom2;
                    Exc.ExcuseSymptom3 = Excuse.Symptom3;
                    Exc.ExcuseSymptom4 = Excuse.Symptom4;

                    flowLayoutPanel3.Controls.Add(Exc);
                }
            }
            if (Type== "Teaching Stuff")
            {
                bunifuImageButton4.Visible = true;
            }
            else
            {
                bunifuImageButton4.Visible = false;
            }
            if (Type == "Student")
            {
                bunifuMetroTextbox7.Visible = true;
                bunifuCustomLabel8.Visible = true;
                bunifuCustomLabel15.Visible = true;
            }
            else
            {
                bunifuMetroTextbox7.Visible = false;
                bunifuCustomLabel8.Visible = false;
                bunifuCustomLabel15.Visible = false;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

            int result = DateTime.Compare(dt1, dt2);
            int resultt = DateTime.Compare(today, dt2);

            if (result >= 0 || resultt > 0)
            {
                MessageBox.Show("Error! Enter Valid dates");
            }
            else if (bunifuMetroTextbox1.Text == "" || bunifuMetroTextbox2.Text == "")
            {
                MessageBox.Show("Error! Fill all requirements");
            }
            else if(Type== "Student"&& bunifuMetroTextbox7.Text=="")
            {
                MessageBox.Show("Enter Teaching Stuff Email");
            }
            else
            {
                string SD = bunifuDatepicker1.Value.ToShortDateString().ToString();
                string ED = bunifuDatepicker2.Value.ToShortDateString().ToString();
              //  ControllerObj.InsertExcuse(SD, ED, bunifuMetroTextbox1.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox6.Text,NationalId);
                if(Type!= "Student")
                {
                    if ((ControllerObj.InsertExcuse(SD, ED, bunifuMetroTextbox1.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox6.Text, NationalId)) == 0)
                    {
                        MessageBox.Show("You already have Medical Excuse with the same start Date");
                    }
                    else
                    {
                        MessageBox.Show("Request Successful!");
                        bunifuMetroTextbox1.Text = "";
                        bunifuMetroTextbox2.Text = "";
                        bunifuMetroTextbox3.Text = "";
                        bunifuMetroTextbox4.Text = "";
                        bunifuMetroTextbox5.Text = "";
                        bunifuMetroTextbox6.Text = "";
                        SD = "";
                        ED = "";
                        bunifuDatepicker2.ResetText();
                        bunifuDatepicker1.ResetText();
                    }
                }
                else if(Type =="Student")//edit here
                {
                    string email = bunifuMetroTextbox7.Text;
                    bool error = false;
                    if(ControllerObj.Get_NationalID(email)==null)
                    {
                        MessageBox.Show("Invalid Email!");
                         error = true;
                    }
                    else if (ControllerObj.Get_Type(email).ToString() != "Teaching Stuff")
                    {
                        MessageBox.Show("Email is not a teaching stuff email");
                    }
                    else
                    {
                        string TNID = ControllerObj.Get_NationalID(email).ToString();
                        if ((ControllerObj.InsertStudentExcuse(SD, ED, bunifuMetroTextbox1.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox6.Text, NationalId, TNID)) == 0)
                        {
                            MessageBox.Show("You already have Medical Excuse with the same start Date or You did Input a Worng Teaching Stuff email");
                        }
                        else
                        {
                            if(Teachinglist.Count()!=0)
                            {
                                for (int i = 0; i < Teachinglist.Count(); i++)
                                {
                                    char[] remove = {' '};
                                    string textnospaces = Teachinglist[i].text.Trim(remove);
                                    if (textnospaces != "")
                                    {

                                        if (ControllerObj.Get_NationalID(textnospaces) == null)
                                        {
                                            MessageBox.Show("1.You already have Medical Excuse with the same start Date or You did Input a Worng Teaching Stuff email");
                                            error = true;
                                        }
                                        else if (ControllerObj.Get_Type(textnospaces).ToString() != "Teaching Stuff")
                                        {
                                            MessageBox.Show("Email is not a teaching stuff email");
                                        }
                                        else
                                        {
                                            TNID = ControllerObj.Get_NationalID(textnospaces).ToString();
                                            if ((ControllerObj.InsertStudentExcuse(SD, ED, bunifuMetroTextbox1.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox6.Text, NationalId, TNID)) == 0)
                                            {
                                                MessageBox.Show("You already have Medical Excuse with the same start Date or You did Input a Worng Teaching Stuff email");
                                            }
                                            else
                                            {
                                                flowLayoutPanel4.Controls.Remove(Teachinglist[i]);
                                                Teachinglist.RemoveAt(i);
                                            }
                                        }
                                    }
                                    else 
                                    {
                                        MessageBox.Show("You have unfilled teaching stuff boxes, it will be ignored!");
                                    }
                                }
                            }
                            if(error != true)
                            {
                                MessageBox.Show("Request Successful!");
                                bunifuMetroTextbox1.Text = "";
                                bunifuMetroTextbox2.Text = "";
                                bunifuMetroTextbox3.Text = "";
                                bunifuMetroTextbox4.Text = "";
                                bunifuMetroTextbox5.Text = "";
                                bunifuMetroTextbox6.Text = "";
                                bunifuMetroTextbox7.Text = "";
                                SD = "";
                                ED = "";
                                bunifuDatepicker1.Value = DateTime.Today;
                                bunifuDatepicker2.Value = DateTime.Today.AddDays(1);
                            }
                            else
                            {
                                error = false;
                            }
                            
                        }
                    }
                   
                }
               

            }
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            dt1 = bunifuDatepicker1.Value;
        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void RequestMedicalExcuse_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }

        private void RequestMedicalExcuse_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachingStuffMedicalExcuses.Instance.Show();
        }

        private void RequestMedicalExcuse_FormClosing(object sender, FormClosingEventArgs e)
        {
            _obj = null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            panel4.Hide();
            panel5.Hide();
            string itemText = e.ClickedItem.Text;
            if (itemText == "Request Excuse")
            {
                panel4.Show();
            }
            if (itemText == "Previous Excuses")
            {
                panel5.Show();

            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            TBM T1 = new TBM();
            Teachinglist.Add(T1);
            flowLayoutPanel4.Controls.Add(T1);

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            dt2 = bunifuDatepicker2.Value;
        }
    }
}
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
    public partial class MedicalExcuses : Form
    {
        static MedicalExcuses _obj;
        int AcceptedCounter = 0;
        int DeclinedCounter = 0;
        string NationalId;
        string Type;
        bool ISEMPTY = false;
        public static MedicalExcuses Instance
        {
            get
            {
                if (_obj == null||_obj.IsDisposed)
                {
                    _obj = new MedicalExcuses();
                }
                return _obj;
            }
        }
        string imagePath = Application.StartupPath + @"\Images";
        List<MedicalExcuseAcceptedDeclined> AcceptedList = new List<MedicalExcuseAcceptedDeclined>();
        List<MedicalExcuseAcceptedDeclined> DeniedList = new List<MedicalExcuseAcceptedDeclined>();
        Controller ControllerObj;
        public MedicalExcuses()
        {
            InitializeComponent();
            NationalId = login.ID;
            Type = login.TYPE;
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.GetAllNullMedicalExcuses();
            List<ExecusesClass> ExcusesList = new List<ExecusesClass>();
            /* ExcusesList.AddRange(new List<ExecusesClass>()
             {
                 new ExecusesClass
                 {
                   Name = "Mariam",
                   Age="20",
                   Major = "CIE",
                   StartDate = "19/10/2021",
                   EndDate="21/10/2021",
                   ImagePath = imagePath + @"\Mariam.jpeg",
                   Symptom1="Fever",
                   Symptom2="DryMouth",
                   Symptom3="Cough",
                   Symptom4=""
                 },
                 new ExecusesClass
                 {
                   Name = "El-Sakka",
                   Age="20",
                   Major = "CIE",
                   StartDate = "18/10/2021",
                   EndDate="22/11/2021",
                   ImagePath = imagePath + @"\Sakka.jpeg",
                   Symptom1="Fever",
                   Symptom2="DryMouth",
                   Symptom3="Cough",
                   Symptom4="Anger"
                 },
                 new ExecusesClass
                 {
                   Name = "El-Sakka",
                   Age="20",
                   Major = "CIE",
                   StartDate = "19/10/2021",
                   EndDate="22/10/2021",
                   ImagePath = imagePath + @"\Sakka.jpeg",
                   Symptom1="Fever",
                   Symptom2="DryMouth",
                   Symptom3="Cough",
                   Symptom4="Anger"
                 },
                 new ExecusesClass
                 {
                   Name = "El-Sakka",
                   Age="20",
                   Major = "CIE",
                   StartDate = "29/10/2021",
                   EndDate="22/10/2021",
                   ImagePath = imagePath + @"\Sakka.jpeg",
                   Symptom1="Fever",
                   Symptom2="DryMouth",
                   Symptom3="Cough",
                   Symptom4="Anger"
                 }
             });*/
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Note this will be done once for each medicalexcuse
                ExecusesClass E = new ExecusesClass
                {
                    Name = dt.Rows[i].ItemArray[0].ToString(),
                    Age = dt.Rows[i].ItemArray[1].ToString(),
                    Major = dt.Rows[i].ItemArray[2].ToString(),
                    StartDate = dt.Rows[i].ItemArray[3].ToString(),
                    EndDate = dt.Rows[i].ItemArray[4].ToString(),
                    ImagePath = imagePath + @"\" + dt.Rows[i].ItemArray[5].ToString(),
                    Symptom1 = dt.Rows[i].ItemArray[6].ToString(),
                    Symptom2 = dt.Rows[i].ItemArray[7].ToString(),
                    Symptom3 = dt.Rows[i].ItemArray[8].ToString(),
                    Symptom4 = dt.Rows[i].ItemArray[9].ToString(),
                    ID = dt.Rows[i].ItemArray[10].ToString()
                };
                ExcusesList.Add(E);

            }

            foreach (var Excuse in ExcusesList)
            {
                MedicalExcuseAcceptingTemp Exc = new MedicalExcuseAcceptingTemp();
                Exc.ExcuseName= Excuse.Name;
                Exc.ExcuseAge= Excuse.Age;
                Exc.ExcuseMajor= Excuse.Major;
                Exc.ExcuseStartDate= Excuse.StartDate;
                Exc.ExcuseEndDate=Excuse.EndDate;
                Exc.ExcuseImage = Image.FromFile(Excuse.ImagePath);
                Exc.ExcuseSymptom1= Excuse.Symptom1;
                Exc.ExcuseSymptom2= Excuse.Symptom2;
                Exc.ExcuseSymptom3= Excuse.Symptom3;
                Exc.ExcuseSymptom4= Excuse.Symptom4;
                Exc.ExcuseID = Excuse.ID;

                flowLayoutPanel1.Controls.Add(Exc);
            }
            if (ExcusesList.Count() == 0)
            {
                ISEMPTY = true;
            }
            else
            {
                ISEMPTY =false;
            }
        }
        public void IfAccept(MedicalExcuseAcceptingTemp Resp)
        {
            MedicalExcuseAcceptedDeclined ExcuseOrder = new MedicalExcuseAcceptedDeclined();

            ExcuseOrder.ExcuseName = Resp.ExcuseName;
            ExcuseOrder.ExcuseAge  = Resp.ExcuseAge;
            ExcuseOrder.ExcuseImage = Resp.ExcuseImage;
            ExcuseOrder.ExcuseMajor = Resp.ExcuseMajor;
            ExcuseOrder.ExcuseStartDate = Resp.ExcuseStartDate;
            ExcuseOrder.ExcuseEndDate = Resp.ExcuseEndDate;
            ExcuseOrder.ExcuseSymptom1 = Resp.ExcuseSymptom1;
            ExcuseOrder.ExcuseSymptom2 = Resp.ExcuseSymptom2;
            ExcuseOrder.ExcuseSymptom3 = Resp.ExcuseSymptom3;
            ExcuseOrder.ExcuseSymptom4 = Resp.ExcuseSymptom4;
            ExcuseOrder.ExcuseID = Resp.ExcuseID;



            flowLayoutPanel4.AutoScrollPosition = new Point(ExcuseOrder.Left, ExcuseOrder.Right);
            flowLayoutPanel4.Controls.Add(ExcuseOrder);
            AcceptedList.Add(ExcuseOrder);
            //ExcuseOrder.QLoad();
            AcceptedCounter++;
            //flowLayoutPanel1.Controls.Add(ExcuseOrder);
            //this.Controls.Add(ExcuseOrder);
            //flowLayoutPanel4.Controls.Add(Resp);
            int X=flowLayoutPanel4.Controls.IndexOf(ExcuseOrder);
            Resp.Parent.Controls.Remove(Resp); //to prevent removing from flowLayout
            ExcuseOrder.Parent.Controls.Add(ExcuseOrder);
            flowLayoutPanel4.Refresh();
        }
        public void IfDeny(MedicalExcuseAcceptingTemp Resp)
        {
            MedicalExcuseAcceptedDeclined ExcuseOrder = new MedicalExcuseAcceptedDeclined();

            ExcuseOrder.ExcuseName = Resp.ExcuseName;
            ExcuseOrder.ExcuseAge = Resp.ExcuseAge;
            ExcuseOrder.ExcuseImage = Resp.ExcuseImage;
            ExcuseOrder.ExcuseMajor = Resp.ExcuseMajor;
            ExcuseOrder.ExcuseStartDate = Resp.ExcuseStartDate;
            ExcuseOrder.ExcuseEndDate = Resp.ExcuseEndDate;
            ExcuseOrder.ExcuseSymptom1 = Resp.ExcuseSymptom1;
            ExcuseOrder.ExcuseSymptom2 = Resp.ExcuseSymptom2;
            ExcuseOrder.ExcuseSymptom3 = Resp.ExcuseSymptom3;
            ExcuseOrder.ExcuseSymptom4 = Resp.ExcuseSymptom4;
            ExcuseOrder.ExcuseID = Resp.ExcuseID;

            DeclinedCounter++;
            flowLayoutPanel3.AutoScrollPosition = new Point(ExcuseOrder.Left, ExcuseOrder.Right);
            DeniedList.Add(ExcuseOrder);
            flowLayoutPanel3.Controls.Add(ExcuseOrder);
            Resp.Parent.Controls.Remove(Resp); //to prevent removing from flowLayout
            flowLayoutPanel3.Refresh();
        }
        public void RemoveExecAccep(MedicalExcuseAcceptedDeclined Resp)
        {
           

            for (int i = 0; i < AcceptedList.Count; i++)
            {
                if (AcceptedList[i].ExcuseStartDate == Resp.ExcuseStartDate && AcceptedList[i].ExcuseName== Resp.ExcuseName)
                {
                    AcceptedCounter--;
                    flowLayoutPanel4.Controls.Remove(AcceptedList[i]);
                    AcceptedList.RemoveAt(i);
                    MedicalExcuseAcceptingTemp ExcuseOrder = new MedicalExcuseAcceptingTemp();

                    ExcuseOrder.ExcuseName = Resp.ExcuseName;
                    ExcuseOrder.ExcuseAge = Resp.ExcuseAge;
                    ExcuseOrder.ExcuseImage = Resp.ExcuseImage;
                    ExcuseOrder.ExcuseMajor = Resp.ExcuseMajor;
                    ExcuseOrder.ExcuseStartDate = Resp.ExcuseStartDate;
                    ExcuseOrder.ExcuseEndDate = Resp.ExcuseEndDate;
                    ExcuseOrder.ExcuseSymptom1 = Resp.ExcuseSymptom1;
                    ExcuseOrder.ExcuseSymptom2 = Resp.ExcuseSymptom2;
                    ExcuseOrder.ExcuseSymptom3 = Resp.ExcuseSymptom3;
                    ExcuseOrder.ExcuseSymptom4 = Resp.ExcuseSymptom4;
                    ExcuseOrder.ExcuseID = Resp.ExcuseID;
                    flowLayoutPanel1.Controls.Add(ExcuseOrder);

                }
            }
        }
        public void RemoveExecDenied(MedicalExcuseAcceptedDeclined Resp)
        {
            for (int i = 0; i < DeniedList.Count; i++)
            {
                if (DeniedList[i].ExcuseStartDate == Resp.ExcuseStartDate && DeniedList[i].ExcuseName == Resp.ExcuseName)
                {
                    DeclinedCounter--;
                    flowLayoutPanel3.Controls.Remove(DeniedList[i]);
                    DeniedList.RemoveAt(i);
                    MedicalExcuseAcceptingTemp ExcuseOrder = new MedicalExcuseAcceptingTemp();

                    ExcuseOrder.ExcuseName = Resp.ExcuseName;
                    ExcuseOrder.ExcuseAge = Resp.ExcuseAge;
                    ExcuseOrder.ExcuseImage = Resp.ExcuseImage;
                    ExcuseOrder.ExcuseMajor = Resp.ExcuseMajor;
                    ExcuseOrder.ExcuseStartDate = Resp.ExcuseStartDate;
                    ExcuseOrder.ExcuseEndDate = Resp.ExcuseEndDate;
                    ExcuseOrder.ExcuseSymptom1 = Resp.ExcuseSymptom1;
                    ExcuseOrder.ExcuseSymptom2 = Resp.ExcuseSymptom2;
                    ExcuseOrder.ExcuseSymptom3 = Resp.ExcuseSymptom3;
                    ExcuseOrder.ExcuseSymptom4 = Resp.ExcuseSymptom4;
                    ExcuseOrder.ExcuseID = Resp.ExcuseID;
                    flowLayoutPanel1.Controls.Add(ExcuseOrder);
                }
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
            //Mariam forms 


            //this.Hide(); 
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////
            ///////////////// I am working here  ////////////////////
            //////////////////// I am working here  ////////////////////
            //////////////////// I am working here  ////////////////////
            //////////////////// I am working here  ////////////////////
            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////
            ///

            
          /*  object Name;
            object Age;
            object Dname;
            object startdate;
            object enddate;
            object ImageLocation;
            object Symptom1;
            object Symptom2;
            object Symptom3;
            object Symptom4;*/
           /* for (int i = 0; i <dt.Rows.Count;i++)
            {
                // Note this will be done once for each medicalexcuse

                Name = dt.Rows[i].ItemArray[0].ToString();
                Age = dt.Rows[i].ItemArray[1].ToString();
                Dname = dt.Rows[i].ItemArray[2].ToString();
                startdate = dt.Rows[i].ItemArray[3].ToString();
                enddate = dt.Rows[i].ItemArray[4].ToString();
                ImageLocation = dt.Rows[i].ItemArray[5].ToString();
                Symptom1 = dt.Rows[i].ItemArray[6].ToString();
                Symptom2 = dt.Rows[i].ItemArray[7].ToString();
                Symptom3 = dt.Rows[i].ItemArray[8].ToString();
                Symptom4 = dt.Rows[i].ItemArray[9].ToString();
            }*/

            ////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////
            //////////////////////// Till here /////////////////////////
            //////////////////////// Till here /////////////////////////
            /////////////////////////// Till here /////////////////////////
            ///////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////
            if (ISEMPTY == true)
            {
                MessageBox.Show("No Pending Medical Excuses!");
            }
            else
            {
                if (AcceptedCounter == 0 && DeclinedCounter == 0)
                {
                    MessageBox.Show("Accept and Deny Some Excuses First!");
                }
                else
                {
                    //------------------------------------------To Do-------------------------------------//
                    //query to set the user excuse state to declined or Accepeted and the default value in database is pending 
                    //------------------------------------------------------------------------------------//
                    for (int i = 0; i < AcceptedList.Count(); i++)
                    {
                        flowLayoutPanel4.Controls.Remove(AcceptedList[i]);

                        ////////////////////////////////////////////////////////////
                        //----------------------To Do----------------------------//
                        //Call the querey that sets the approval state to 1
                        ////////////////////////////////////////////////////////////
                        ControllerObj.ExcuseUpdate(AcceptedList[i].ExcuseID, true, AcceptedList[i].ExcuseStartDate);

                        //AcceptedList[i].ExcuseStartDate
                        //flowLayoutPanel2.Controls.Add(cartlist[i]);
                    }
                    AcceptedList.Clear();
                    for (int i = 0; i < DeniedList.Count(); i++)
                    {
                        flowLayoutPanel3.Controls.Remove(DeniedList[i]);
                        ControllerObj.ExcuseUpdate(DeniedList[i].ExcuseID, false, DeniedList[i].ExcuseStartDate);
                        ////////////////////////////////////////////////////////////
                        //----------------------To Do----------------------------//
                        //Call the querey that sets the approval state to 0
                        ////////////////////////////////////////////////////////////

                        //flowLayoutPanel2.Controls.Add(cartlist[i]);
                    }
                    DeniedList.Clear();
                    //if()
                    //ISEMPTY = true;
                    AcceptedCounter = 0; DeclinedCounter = 0;
                    MessageBox.Show("Confirmed!");
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //no need to fill;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //new instance of the appointment form bsed on the type
            if (Type == "Nurse" || Type == "Doctor")
            {
                this.Hide();
                ViewAppointments.Instance.Show();
                //Appointment view doctors
                //new DrugsEntry().Show();
            }
            else if (Type == "Student" || Type == "Teaching Stuff" || Type == "Admin")
            {
                this.Hide();
                BookAppointment.Instance.Show();
                //appointment book with dr
                //Drugs.Instance.Show();
            }
            //new Appointment().Show();
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
            //this.Hide();
            //Drugs.Instance.Show();
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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();

        }

        private void MedicalExcuses_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospital.Instance.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new Statistics().Show();
        }

        private void MedicalExcuses_FormClosing(object sender, FormClosingEventArgs e)
        {
            _obj = null;
        }
    }
}

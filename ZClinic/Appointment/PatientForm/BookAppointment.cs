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
using ZClinic.Appointment;
using ZClinic.Appointment.PatientForm;

namespace ZClinic
{
    public partial class BookAppointment : Form
    {
        static BookAppointment _obj;
        public static BookAppointment Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new BookAppointment();
                }
                return _obj;
            }
        }

        string imagePath = Application.StartupPath + @"\Images";
        //int bookCounter = 0;
        List<ChooseAppointments> ChooseAppointmentlist = new List<ChooseAppointments>();
        List<UpcomingPreviousAppointment> PreviousAppointmentList = new List<UpcomingPreviousAppointment>();
        List<UpcomingPreviousAppointment> UpcomingAppointmentList = new List<UpcomingPreviousAppointment>();

        //List<AppointmentDoctorMini> UpcomingList = new List<AppointmentDoctorMini>();//to hold upcoming appointments...to be loaded from the database should be updated continously
        //List<AppointmentDoctorMini> OverList = new List<AppointmentDoctorMini>();//to hold over appointments....would be filled from the database should be updated continously
        public BookAppointment()
        {
            InitializeComponent();
            if (PreviousAppointmentList.Count == 0)
                bunifuFlatButton10.Enabled = false;
            List<UpcomingPreviousAppointmentClass> UpcomingPreviousAppointmentClassList = new List<UpcomingPreviousAppointmentClass>();
            UpcomingPreviousAppointmentClassList.AddRange(new List<UpcomingPreviousAppointmentClass>()
            {
                new UpcomingPreviousAppointmentClass
                {
                    ImagePath=imagePath + @"\Mariam.jpeg",
                    Name = "Mariam Elseedawy",
                    Email = "s-mariam.elseedawy@zewailcity.edu.eg",
                    Date = "07/06/2021",
                    Time = "02:30 PM"
                },
                new UpcomingPreviousAppointmentClass
                {
                    ImagePath=imagePath + @"\Sakka.jpeg",
                    Name = "Omar ElSakka",
                    Email = "s-mariam.elseedawy@zewailcity.edu.eg",
                    Date = "07/06/2021",
                    Time = "02:30 PM"
                },
                new UpcomingPreviousAppointmentClass
                {
                    ImagePath=imagePath + @"\Sakka.jpeg",
                    Name = "Omar ElSakka",
                    Email = "s-omar.elsakka@zewailcity.edu.eg",
                    Date = "07/06/2021",
                    Time = "01:30 PM"
                },
                new UpcomingPreviousAppointmentClass
                {
                    ImagePath=imagePath + @"\Mariam.jpeg",
                    Name = "Mariam Elseedawy",
                    Email = "s-mariam.elseedawy@zewailcity.edu.eg",
                    Date = "06/06/2021",
                    Time = "02:30 PM"
                }
            });
            foreach (var inChooseAppointment in UpcomingPreviousAppointmentClassList)
            {
                ChooseAppointments ChooseAppointmentt = new ChooseAppointments();
                //shcommentt.ShowingCommentImage = Image.FromFile(shcomment.ImagePath);
                ChooseAppointmentt.ChooseAppointmentImagePath = Image.FromFile(inChooseAppointment.ImagePath);
                ChooseAppointmentt.ChooseAppointmentName = inChooseAppointment.Name;
                ChooseAppointmentt.ChooseAppointmentEmail = inChooseAppointment.Email;
                ChooseAppointmentt.ChooseAppointmentDate = inChooseAppointment.Date;
                ChooseAppointmentt.ChooseAppointmentTime = inChooseAppointment.Time;
                ChooseAppointmentlist.Add(ChooseAppointmentt);
                //bunifuFlatButton11.Enabled = true;
                flowLayoutPanel1.Controls.Add(ChooseAppointmentt);
                //cartlist.Add(commentt);
                //commentt.MouseDown += Comment_MouseDown;
                //medicine.MouseClick += Medicens_MouseHover;
            }
            List<UpcomingPreviousAppointmentClass> UpcomingPreviousAppointmentClassListt = new List<UpcomingPreviousAppointmentClass>();
            UpcomingPreviousAppointmentClassList.AddRange(new List<UpcomingPreviousAppointmentClass>()
            {
                new UpcomingPreviousAppointmentClass
                {
                    ImagePath=imagePath + @"\Mariam.jpeg",
                    Name = "Mariam Elseedawy",
                    Email = "s-mariam.elseedawy@zewailcity.edu.eg",
                    Date = "07/06/2021",
                    Time = "02:30 PM"
                },
                new UpcomingPreviousAppointmentClass
                {
                    ImagePath=imagePath + @"\Sakka.jpeg",
                    Name = "Omar ElSakka",
                    Email = "s-mariam.elseedawy@zewailcity.edu.eg",
                    Date = "07/06/2021",
                    Time = "02:30 PM"
                },
                new UpcomingPreviousAppointmentClass
                {
                    ImagePath=imagePath + @"\Sakka.jpeg",
                    Name = "Omar ElSakka",
                    Email = "s-omar.elsakka@zewailcity.edu.eg",
                    Date = "07/06/2021",
                    Time = "01:30 PM"
                },
                new UpcomingPreviousAppointmentClass
                {
                    ImagePath=imagePath + @"\Mariam.jpeg",
                    Name = "Mariam Elseedawy",
                    Email = "s-mariam.elseedawy@zewailcity.edu.eg",
                    Date = "06/06/2021",
                    Time = "02:30 PM"
                }

            });
            foreach (var inChooseAppointment in UpcomingPreviousAppointmentClassList)
            {
                UpcomingPreviousAppointment ChooseAppointmentt = new UpcomingPreviousAppointment();
                //shcommentt.ShowingCommentImage = Image.FromFile(shcomment.ImagePath);
                ChooseAppointmentt.UpcomingPreviousAppointmentImagePath = Image.FromFile(inChooseAppointment.ImagePath);
                ChooseAppointmentt.UpcomingPreviousAppointmentName = inChooseAppointment.Name;
                ChooseAppointmentt.UpcomingPreviousAppointmentEmail = inChooseAppointment.Email;
                ChooseAppointmentt.UpcomingPreviousAppointmentDate = inChooseAppointment.Date;
                ChooseAppointmentt.UpcomingPreviousAppointmentTime = inChooseAppointment.Time;
                PreviousAppointmentList.Add(ChooseAppointmentt);
                bunifuFlatButton10.Enabled = true;
                flowLayoutPanel2.Controls.Add(ChooseAppointmentt);
                //cartlist.Add(commentt);
                //commentt.MouseDown += Comment_MouseDown;
                //medicine.MouseClick += Medicens_MouseHover;
            }
        }
        public void RemoveAllPrevious()
        {
            int n = PreviousAppointmentList.Count;
            for (int i = 0; i < n; i++)
            {
                flowLayoutPanel2.Controls.Remove(PreviousAppointmentList[0]);
                PreviousAppointmentList.RemoveAt(0);
                bunifuFlatButton10.Enabled = false;
            }
        }
        public void Choose(ChooseAppointments ca)
        {
            if (UpcomingAppointmentList.Count != 0)
            {
                ChooseAppointments ChooseAppointmentttt = new ChooseAppointments();
                //shcommentt.ShowingCommentImage = Image.FromFile(shcomment.ImagePath);
                ChooseAppointmentttt.ChooseAppointmentImagePath = UpcomingAppointmentList[0].UpcomingPreviousAppointmentImagePath;
                ChooseAppointmentttt.ChooseAppointmentName = UpcomingAppointmentList[0].UpcomingPreviousAppointmentName;
                ChooseAppointmentttt.ChooseAppointmentEmail = UpcomingAppointmentList[0].UpcomingPreviousAppointmentEmail;
                ChooseAppointmentttt.ChooseAppointmentDate = UpcomingAppointmentList[0].UpcomingPreviousAppointmentDate;
                ChooseAppointmentttt.ChooseAppointmentTime = UpcomingAppointmentList[0].UpcomingPreviousAppointmentTime;
                ChooseAppointmentlist.Add(ChooseAppointmentttt);
                flowLayoutPanel1.Controls.Add(ChooseAppointmentttt);
                //bunifuFlatButton10.Enabled = true;
                //flowLayoutPanel2.Controls.Add(ChooseAppointmentt);
                flowLayoutPanel4.Controls.Remove(UpcomingAppointmentList[0]);
                UpcomingAppointmentList.RemoveAt(0);
            }

            int n = ChooseAppointmentlist.Count;
            //MessageBox.Show(n.ToString());
            for (int i = 0; i < n; i++)
            {
                //MessageBox.Show(i.ToString());

                if (ChooseAppointmentlist[i].ChooseAppointmentEmail == ca.ChooseAppointmentEmail &&
                    ChooseAppointmentlist[i].ChooseAppointmentDate == ca.ChooseAppointmentDate &&
                    ChooseAppointmentlist[i].ChooseAppointmentTime == ca.ChooseAppointmentTime)
                {
                    UpcomingPreviousAppointment ChooseAppointmentttt = new UpcomingPreviousAppointment();
                    //shcommentt.ShowingCommentImage = Image.FromFile(shcomment.ImagePath);
                    ChooseAppointmentttt.UpcomingPreviousAppointmentImagePath = ca.ChooseAppointmentImagePath;
                    ChooseAppointmentttt.UpcomingPreviousAppointmentName = ca.ChooseAppointmentName;
                    ChooseAppointmentttt.UpcomingPreviousAppointmentEmail = ca.ChooseAppointmentEmail;
                    ChooseAppointmentttt.UpcomingPreviousAppointmentDate = ca.ChooseAppointmentDate;
                    ChooseAppointmentttt.UpcomingPreviousAppointmentTime = ca.ChooseAppointmentTime;
                    UpcomingAppointmentList.Add(ChooseAppointmentttt);
                    flowLayoutPanel4.Controls.Add(ChooseAppointmentttt);
                    //bunifuFlatButton10.Enabled = true;
                    //flowLayoutPanel2.Controls.Add(ChooseAppointmentt);
                    flowLayoutPanel1.Controls.Remove(ca);
                    ChooseAppointmentlist.RemoveAt(i);
                    break;

                }
                //flowLayoutPanel2.Controls.Remove(PreviousAppointmentList[0]);
                //PreviousAppointmentList.RemoveAt(0);
                //bunifuFlatButton10.Enabled = false;
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //public void Booker(AppointmentDoctor appointment)
        //{
        //    AppointmentDoctorMini doctorMini = new AppointmentDoctorMini();
        //    doctorMini.DoctorName = appointment.DoctorName;
        //    doctorMini.DoctorAge = appointment.DoctorAge;
        //    doctorMini.DoctorSpecialization = appointment.DoctorSpecialization;
        //    doctorMini.DoctorImage = appointment.DoctorImage;
        //    doctorMini.BookDate = appointment.BookDate;

        //    bool found = false;
        //    MedicineOrder drugOrder = new MedicineOrder();
        //    if (bookList.Count != 0)
        //    {
        //        for (int i = 0; i < bookList.Count; i++)
        //        {
        //            if (bookList[i].DoctorName == appointment.DoctorName)
        //            {
        //                found = true;
        //            }
        //        }
        //    }
        //    if(found==false)
        //    {
        //        flowLayoutPanel2.AutoScrollPosition = new Point(doctorMini.Left, doctorMini.Right);
        //        flowLayoutPanel2.Controls.Add(doctorMini);
        //        bookList.Add(doctorMini);
        //        bookCounter++;
        //    }
        //    else
        //    {
        //        MessageBox.Show("You Can't book with same Doctor More than Once");
        //    }
        //    found = false;
        //    bunifuMaterialTextbox3.Text=bookCounter.ToString();

        //}
        //public void RemoveApp(AppointmentDoctorMini app)
        //{
        //    for (int i = 0; i < bookList.Count; i++)
        //    {
        //        if (bookList[i].DoctorName == app.DoctorName)
        //        {
        //            bookCounter--;
        //            flowLayoutPanel2.Controls.Remove(bookList[i]);
        //            bunifuMaterialTextbox3.Text = bookCounter.ToString();
        //            bookList.RemoveAt(i);

        //        }
        //    }
        //}
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            // bunifuMaterialTextbox3.Text = bookCounter.ToString();
        }

        //private void bunifuFlatButton10_Click(object sender, EventArgs e)
        //{
        //    if (bookCounter == 0)
        //    {
        //        MessageBox.Show("Book Appointments First!");
        //    }
        //    else
        //    {
        //        //------------------------------------------To Do-------------------------------------//
        //        //query to update user balance
        //        //query to send those medicines to be recorded that they are ordered with the patient
        //        //------------------------------------------------------------------------------------//
        //        for (int i = 0; i < bookList.Count(); i++)
        //        {
        //            flowLayoutPanel2.Controls.Remove(bookList[i]);
        //            //flowLayoutPanel2.Controls.Add(cartlist[i]);
        //        }
        //        bookCounter = 0;
        //        bookList.Clear();
        //        bunifuMaterialTextbox3.Text = "";
        //        MessageBox.Show("Book Successful!");
        //    }
        //}

        private void addCommnetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            RemoveAllPrevious();
        }
    }
}

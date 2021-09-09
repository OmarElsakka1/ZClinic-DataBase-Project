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
    public partial class Admin : Form
    {
        Controller ControllerObj;
        static Admin _obj;
        public static Admin Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Admin();
                }
                return _obj;
            }
        }
        string imagePath = Application.StartupPath + @"\Images";
        //Admin mControl;
        List<SignUpRequest> SignUpRequestlist = new List<SignUpRequest>();
        List<SignUpAcceptedDeclined> SignUpAcceptedlist = new List<SignUpAcceptedDeclined>();
        List<SignUpAcceptedDeclined> SignUpDeclinedlist = new List<SignUpAcceptedDeclined>();
        public Admin()
        {
            InitializeComponent();
            if (SignUpAcceptedlist.Count != 0 || SignUpDeclinedlist.Count != 0)
            {
                bunifuFlatButton10.Enabled = true;
            }
            else
            {
                bunifuFlatButton10.Enabled = false;
            }
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.FillAdmin();
            List<SignUpClass> SignUpClassClassList = new List<SignUpClass>();
            /*SignUpClassClassList.AddRange(new List<SignUpClass>()
            {
                new SignUpClass
                {
                  ImagePath = imagePath + @"\Mariam.jpeg",
                  Name = "Mariam Elseedawy",
                  //ID = "201901281",
                  Email = "s-mariam.elseedawy@zewailcity.edu.eg",
                  //SComment = "syaaaaaaaaaaaaaaaaaaaaaaaaaa7 aaaaaaaaaaa"
                 },
                new SignUpClass
                {
                  ImagePath = imagePath + @"\Sakka.jpeg",
                  Name = "Omar Elsakka",
                  //ID = "201900773",
                  Email = "s-omar.elsakka@zewailcity.edu.eg",
                  //SComment = "Aloooooooooooooooooooooooooooooooo"
                }
            });*/
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // Note this will be done once for each medicalexcuse
                    SignUpClass E = new SignUpClass
                    {
                        Name = dt.Rows[i].ItemArray[0].ToString(),
                        ImagePath = imagePath + @"\" + dt.Rows[i].ItemArray[2].ToString(),
                        Email = dt.Rows[i].ItemArray[1].ToString()
                    };
                    SignUpClassClassList.Add(E);

                }
                foreach (var suclass in SignUpClassClassList)
                {
                    SignUpRequest sucontrol = new SignUpRequest();
                    sucontrol.SignUpRequestImagePath = Image.FromFile(suclass.ImagePath);
                    sucontrol.SignUpRequestName = suclass.Name;
                    sucontrol.SignUpRequestEmail = suclass.Email;
                    SignUpRequestlist.Add(sucontrol);
                    flowLayoutPanel1.Controls.Add(sucontrol);
                    //hospitall.MouseDown += Hospitals_MouseDown;
                }
            }

        }

        public void Accept(SignUpRequest request)
        {
            int n = SignUpRequestlist.Count;
            for (int i = 0; i < n; i++)
            {
                if (SignUpRequestlist[i].SignUpRequestEmail == request.SignUpRequestEmail)
                {
                    SignUpAcceptedDeclined accepted = new SignUpAcceptedDeclined();
                    //shcommentt.ShowingCommentImage = Image.FromFile(shcomment.ImagePath);
                    accepted.SignUpAcceptedDeclinedImagePath = request.SignUpRequestImagePath;
                    accepted.SignUpAcceptedDeclinedName = request.SignUpRequestName;
                    accepted.SignUpAcceptedDeclinedEmail = request.SignUpRequestEmail;
                    SignUpAcceptedlist.Add(accepted);
                    flowLayoutPanel4.Controls.Add(accepted);
                    SignUpRequestlist.RemoveAt(i);
                    flowLayoutPanel1.Controls.Remove(request);
                    bunifuFlatButton10.Enabled = true;
                    break;
                }
            }
        }
        public void Decline(SignUpRequest request)
        {
            int n = SignUpRequestlist.Count;
            for (int i = 0; i < n; i++)
            {
                if (SignUpRequestlist[i].SignUpRequestEmail == request.SignUpRequestEmail)
                {
                    SignUpAcceptedDeclined declined = new SignUpAcceptedDeclined();
                    //shcommentt.ShowingCommentImage = Image.FromFile(shcomment.ImagePath);
                    declined.SignUpAcceptedDeclinedImagePath = request.SignUpRequestImagePath;
                    declined.SignUpAcceptedDeclinedName = request.SignUpRequestName;
                    declined.SignUpAcceptedDeclinedEmail = request.SignUpRequestEmail;
                    SignUpDeclinedlist.Add(declined);
                    flowLayoutPanel3.Controls.Add(declined);
                    //bunifuFlatButton10.Enabled = true;
                    SignUpRequestlist.RemoveAt(i);
                    flowLayoutPanel1.Controls.Remove(request);
                    bunifuFlatButton10.Enabled = true;

                    break;
                }
            }
        }

        public void AddAgain(SignUpAcceptedDeclined med)
        {
            int n1 = SignUpAcceptedlist.Count;
            int n2 = SignUpDeclinedlist.Count;
            for (int i = 0; i < n1; i++)
            {
                if (SignUpAcceptedlist[i].SignUpAcceptedDeclinedName == med.SignUpAcceptedDeclinedName)
                {
                    SignUpRequest surequest = new SignUpRequest();
                    surequest.SignUpRequestName = med.SignUpAcceptedDeclinedName;
                    surequest.SignUpRequestEmail = med.SignUpAcceptedDeclinedEmail;
                    surequest.SignUpRequestImagePath = med.SignUpAcceptedDeclinedImagePath;
                    SignUpRequestlist.Add(surequest);
                    flowLayoutPanel1.Controls.Add(surequest);
                    SignUpAcceptedlist.RemoveAt(i);
                    flowLayoutPanel4.Controls.Remove(med);
                    break;
                }
            }
            for (int i = 0; i < n2; i++)
            {
                if (SignUpDeclinedlist[i].SignUpAcceptedDeclinedName == med.SignUpAcceptedDeclinedName)
                {
                    SignUpRequest surequest = new SignUpRequest();
                    surequest.SignUpRequestName = med.SignUpAcceptedDeclinedName;
                    surequest.SignUpRequestEmail = med.SignUpAcceptedDeclinedEmail;
                    surequest.SignUpRequestImagePath = med.SignUpAcceptedDeclinedImagePath;
                    SignUpRequestlist.Add(surequest);
                    flowLayoutPanel1.Controls.Add(surequest);
                    SignUpDeclinedlist.RemoveAt(i);
                    flowLayoutPanel3.Controls.Remove(med);
                    break;
                }
            }
            if (SignUpAcceptedlist.Count == 0 && SignUpDeclinedlist.Count == 0)
                bunifuFlatButton10.Enabled = false;

        }

        public void RemoveAll()
        {
            int n1 = SignUpAcceptedlist.Count;
            int n2 = SignUpDeclinedlist.Count;
            for (int i = 0; i < n1; i++)
            {
               string email = SignUpAcceptedlist[i].SignUpAcceptedDeclinedEmail;
                ControllerObj.UpdateUserState(email);
                flowLayoutPanel4.Controls.Remove(SignUpAcceptedlist[i]);
                SignUpAcceptedlist.RemoveAt(i);
            }
            for (int i = 0; i < n2; i++)
            {
                // string email = SignUpAcceptedlist[i].SignUpAcceptedDeclinedEmail;
                //  ControllerObj.UpdateUserState(email);
                string email = SignUpAcceptedlist[i].SignUpAcceptedDeclinedEmail;
                ControllerObj.UpdateUserStateDec(email);
                flowLayoutPanel3.Controls.Remove(SignUpDeclinedlist[i]);
                SignUpDeclinedlist.RemoveAt(i);
            }
            bunifuFlatButton10.Enabled = false;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard.Instance.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportIT.Instance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

            RemoveAll();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            AdminDashboard.Instance.Close();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            AdminDashboard.Instance.Close();

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }
    }
}

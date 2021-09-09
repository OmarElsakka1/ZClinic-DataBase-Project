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
    public partial class SupportIT : Form
    {
        string NationalId;
        string Type;
        static SupportIT _obj;
        public static SupportIT Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new SupportIT();
                }
                return _obj;
            }
        }
        string imagePath = Application.StartupPath + @"\Images";
        Controller ControllerObj;
        //SupportIT mControl;
        //  List<ShowingComment> ShowingCommentlist = new List<ShowingComment>();
        List<ShowingComment> ShowingCommentlist = new List<ShowingComment>();
        List<RevisedComments> RevisedCommentlist = new List<RevisedComments>();

        public SupportIT()
        {
            InitializeComponent();
            ControllerObj = new Controller();
            NationalId = login.ID;
            Type = login.TYPE;
          
            List<ShowingCommentClass> ShowingCommentClassList = new List<ShowingCommentClass>();
            List<ShowingCommentClass> RevisedShowingCommentClasslist = new List<ShowingCommentClass>();



            /* ShowingCommentClassList.AddRange(new List<ShowingCommentClass>()
             {
                 new ShowingCommentClass
                 {
                   ImagePath = imagePath + @"\Mariam.jpeg",
                   Name = "Mariam Elseedawy",
                   //ID = "201901281",
                   Email = "s-mariam.elseedawy@zewailcity.edu.eg",
                   SComment = "syaaaaaaaaaaaaaaaaaaaaaaaaaa7 aaaaaaaaaaa"
                  },
                 new ShowingCommentClass
                 {
                   ImagePath = imagePath + @"\Sakka.jpeg",
                   Name = "Omar Elsakka",
                   //ID = "201900773",
                   Email = "s-omar.elsakka@zewailcity.edu.eg",
                   SComment = "Aloooooooooooooooooooooooooooooooo"
                 }
             });*/
            DataTable dt = ControllerObj.FillSupportIT();
            if (dt!=null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // Note this will be done once for each medicalexcuse
                    ShowingCommentClass E = new ShowingCommentClass
                    {
                        SComment = dt.Rows[i].ItemArray[3].ToString(),
                        Name = dt.Rows[i].ItemArray[1].ToString(),
                        ImagePath = imagePath + @"\" + dt.Rows[i].ItemArray[0].ToString(),
                        Email = dt.Rows[i].ItemArray[2].ToString()
                    };
                    ShowingCommentClassList.Add(E);

                }

                foreach (var shcomment in ShowingCommentClassList)
                {
                    ShowingComment shcommentt = new ShowingComment();
                    shcommentt.ShowingCommentImage = Image.FromFile(shcomment.ImagePath);
                    shcommentt.ShowingCommentName = shcomment.Name;
                    //shcommentt.ShowingCommentID = shcomment.ID;
                    shcommentt.ShowingCommentEmail = shcomment.Email;
                    shcommentt.ShowingCommentComment = shcomment.SComment;
                    ShowingCommentlist.Add(shcommentt);
                    flowLayoutPanel1.Controls.Add(shcommentt);
                    //hospitall.MouseDown += Hospitals_MouseDown;
                }
            }
            else 
            {
            }
           
            DataTable dM = ControllerObj.FillRevisedSupportIT();
            if(dM!=null)
            {
                for (int i = 0; i < dM.Rows.Count; i++)
                {
                    // Note this will be done once for each medicalexcuse
                    ShowingCommentClass E = new ShowingCommentClass
                    {
                        SComment = dM.Rows[i].ItemArray[3].ToString(),
                        Name = dM.Rows[i].ItemArray[1].ToString(),
                        ImagePath = imagePath + @"\" + dM.Rows[i].ItemArray[0].ToString(),
                        Email = dM.Rows[i].ItemArray[2].ToString()
                    };
                    RevisedShowingCommentClasslist.Add(E);

                }

                foreach (var shcomment in RevisedShowingCommentClasslist)
                {
                    RevisedComments shcommentt = new RevisedComments();
                    shcommentt.RevisedCommentsImage = Image.FromFile(shcomment.ImagePath);
                    shcommentt.RevisedCommentsName = shcomment.Name;
                    //shcommentt.ShowingCommentID = shcomment.ID;
                    shcommentt.RevisedCommentsEmail = shcomment.Email;
                    shcommentt.RevisedCommentsComment = shcomment.SComment;
                    RevisedCommentlist.Add(shcommentt);
                    flowLayoutPanel4.Controls.Add(shcommentt);
                    //hospitall.MouseDown += Hospitals_MouseDown;
                }
            }
            else
            {

            }
           
        }

        public void Remove_Add(ShowingComment med)
        {
            int n = ShowingCommentlist.Count;
            for (int i = 0; i < n; i++)
            {
                if (ShowingCommentlist[i].ShowingCommentEmail == med.ShowingCommentEmail &&
                    ShowingCommentlist[i].ShowingCommentComment == med.ShowingCommentComment)
                {
                    RevisedComments Rcommentt = new RevisedComments();
                    string ID = ControllerObj.Get_NationalID(med.ShowingCommentEmail).ToString();

                    //shcommentt.ShowingCommentImage = Image.FromFile(shcomment.ImagePath);
                    Rcommentt.RevisedCommentsImage = med.ShowingCommentImage;
                    Rcommentt.RevisedCommentsName = med.ShowingCommentName;
                    Rcommentt.RevisedCommentsEmail = med.ShowingCommentEmail;
                    Rcommentt.RevisedCommentsComment = med.ShowingCommentComment;
                    ControllerObj.SetUNRevisedSupportIT(ID, med.ShowingCommentComment);

                    if (ControllerObj.SetRevisedSupportIT(ID, med.ShowingCommentComment)==0)
                    {
                        MessageBox.Show("yalahwy...Error!");
                    }

                    RevisedCommentlist.Add(Rcommentt);
                    flowLayoutPanel4.Controls.Add(Rcommentt);
                    bunifuFlatButton10.Enabled = true;
                    ShowingCommentlist.RemoveAt(i);
                    flowLayoutPanel1.Controls.Remove(med);

                    break;
                }
            }
        }

        public void AddAgain(RevisedComments med)
        {
            int n = RevisedCommentlist.Count;
            for (int i = 0; i < n; i++)
            {
                if (RevisedCommentlist[i].RevisedCommentsEmail == med.RevisedCommentsEmail &&
                    RevisedCommentlist[i].RevisedCommentsComment == med.RevisedCommentsComment)
                {
                    string ID = ControllerObj.Get_NationalID(med.RevisedCommentsEmail).ToString();
                    ShowingComment shhcommentt = new ShowingComment();
                    shhcommentt.ShowingCommentImage = med.RevisedCommentsImage;
                    shhcommentt.ShowingCommentName = med.RevisedCommentsName;
                    shhcommentt.ShowingCommentEmail = med.RevisedCommentsEmail;
                    shhcommentt.ShowingCommentComment = med.RevisedCommentsComment;
                    ShowingCommentlist.Add(shhcommentt);
                    flowLayoutPanel1.Controls.Add(shhcommentt);
                    RevisedCommentlist.RemoveAt(i);
                    flowLayoutPanel4.Controls.Remove(med);
                    

                    break;
                }
            }
            if (RevisedCommentlist.Count == 0)
                bunifuFlatButton10.Enabled = false;

        }

        public void RemoveAll()
        {
            int n = RevisedCommentlist.Count;
            for (int i = 0; i < n; i++)
            {
                flowLayoutPanel4.Controls.Remove(RevisedCommentlist[i]);
                RevisedCommentlist.RemoveAt(i);
                bunifuFlatButton10.Enabled = false;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            new AdminDashboard().Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ContactDevelopers().Show();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            int n = RevisedCommentlist.Count;
            for (int i = 0; i < n; i++)
            {
                string comment=RevisedCommentlist[i].RevisedCommentsComment;
                string email=RevisedCommentlist[i].RevisedCommentsEmail;
                string ID = ControllerObj.Get_NationalID(email).ToString();
                ControllerObj.DeleteSupportIT(ID, comment);
               // RevisedCommentlist.RemoveAt(i);
            }

             
            RemoveAll();
        }

        private void SupportIT_Load(object sender, EventArgs e)
        {
            if (RevisedCommentlist.Count == 0)
            {
                bunifuFlatButton10.Enabled = false;
            }
            else
            {
                bunifuFlatButton10.Enabled = true;
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard.Instance.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Instance.Show();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            AdminDashboard.Instance.Close();
        }

        private void SupportIT_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            AdminDashboard.Instance.Close();
        }
    }
}
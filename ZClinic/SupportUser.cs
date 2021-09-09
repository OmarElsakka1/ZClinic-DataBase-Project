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
    public partial class SupportUser : Form
    {
        string ID;
        string Type;
        static SupportUser _obj;
        public static SupportUser Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new SupportUser();
                }
                return _obj;
            }
        }

        //public FlowLayoutPanel FLayout
        //{
        //    get { return flowLayoutPanel2; }

        //}
        Comment mControl;
        List<Comment> ComList = new List<Comment>();
        Controller ControllerObj;

        public SupportUser()
        {
            InitializeComponent();
            ID = login.ID;
            Type = login.TYPE;
            ControllerObj = new Controller();
            DataTable dt = ControllerObj.Get_All_MyIssues(ID);

            panel4.Show();
            panel5.Hide();
            //if (ComList.Count == 0)
            //{
            //    bunifuFlatButton8.Enabled = false;
            //}
            //else
            //{
            //    bunifuFlatButton8.Enabled = true;
            //}
            List<CommentClass> commentsList = new List<CommentClass>();

            //for Debugging after debugging a for loop from the backend will fill this
            /* commentsList.AddRange(new List<CommentClass>()
             {
                 new CommentClass
                 {
                   comment = "Tmam"
                 },
                 new CommentClass
                 {
                   comment = "This is a nonsense comment :) btee5"
                 }
             });*/
           if(dt!=null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CommentClass A = new CommentClass
                    {
                        comment = dt.Rows[i].ItemArray[0].ToString()
                    };
                    commentsList.Add(A);
                }
            }
          

        
            foreach (var comment in commentsList)
            {
                Comment commentt = new Comment();
                commentt.Commentss = comment.comment;
                ComList.Add(commentt);
                bunifuFlatButton8.Enabled = true;
                flowLayoutPanel1.Controls.Add(commentt);
                //cartlist.Add(commentt);
                //commentt.MouseDown += Comment_MouseDown;
                //medicine.MouseClick += Medicens_MouseHover;
            }
        }

        /* private void Comment_MouseDown(object sender, MouseEventArgs e)
         {
             mControl = (Comment)sender;
             Bitmap bitmap = new Bitmap(mControl.Width, mControl.Height);
             mControl.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
             Cursor cursor = new Cursor(bitmap.GetHicon());
             Cursor.Current = cursor;
             this.DoDragDrop(mControl, DragDropEffects.All);
         }*/

        public void RemoveMed(Comment med)
        {
            int n = ComList.Count;
            for (int i = 0; i < n; i++)
            {
                if (ComList[i].Commentss == med.Commentss)
                {
                    ComList.RemoveAt(i);
                    flowLayoutPanel1.Controls.Remove(med);
                    break;
                }
            }
            if (ComList.Count == 0)
                bunifuFlatButton8.Enabled = false;

            //for (int i = 0; i < cartlist.Count; i++)
            //{
            //    if (cartlist[i].Commentss == med.Commentss)
            //    {

            //        cartlist.RemoveAt(i);
            //    }
            //}
        }

        public void RemoveAll()
        {
            int n = ComList.Count;
            for (int i = 0; i < n; i++)
            {
                flowLayoutPanel1.Controls.Remove(ComList[0]);
                ComList.RemoveAt(0);
                bunifuFlatButton8.Enabled = false;
            }

            //for (int i = 0; i < cartlist.Count; i++)
            //{
            //    if (cartlist[i].Commentss == med.Commentss)
            //    {

            //        cartlist.RemoveAt(i);
            //    }
            //}
        }

        private void SupportUser_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Write your comment here...";
                bunifuFlatButton10.Enabled = false;
            }
            else
            {
                bunifuFlatButton10.Enabled = true;
            }
            //if (ComList.Count == 0)
            //{
            //    bunifuFlatButton8.Enabled = false;
            //}
            //else
            //{
            //    bunifuFlatButton8.Enabled = true;
            //}
        }

        private void addCommnetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            panel4.Hide();
            panel5.Hide();
            string itemText = e.ClickedItem.Text;
            if (itemText == "Add comment")
            {
                panel4.Show();
            }
            if (itemText == "Previous")
            {
                panel5.Show();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            string newComment = textBox1.Text;
            DateTime today = DateTime.Today;
            string Date=today.ToString();
            Comment commentt = new Comment();
            commentt.Commentss = newComment;
            ComList.Add(commentt);
            bunifuFlatButton8.Enabled = true;
            flowLayoutPanel1.Controls.Add(commentt);
            ControllerObj.InsertSupport(ID, Date, newComment);
            textBox1.Text = "Write your comment here...";
            bunifuFlatButton10.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bunifuFlatButton10.Enabled = true;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Write your comment here...")
                textBox1.Text = "";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            new BookAppointment().Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //this.Close();
            //new RequestMedicalExcuse().Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Drugs.Instance.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Hospital().Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            RemoveAll();
        }

        private void SupportUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
                Dashboard.Instance.Close();
            
           
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
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

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
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

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
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

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Hospital.Instance.Show();
        }

        private void bunifuFlatButton6_Click_1(object sender, EventArgs e)
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

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }
    }
}